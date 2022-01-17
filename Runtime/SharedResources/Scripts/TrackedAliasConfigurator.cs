namespace Tilia.CameraRigs.TrackedAlias
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Rule;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Tracking.Follow;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Sets up the Tracked Alias Prefab based on the provided user settings.
    /// </summary>
    public class TrackedAliasConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public TrackedAliasFacade Facade { get; protected set; }
        #endregion

        #region Object Follow Settings
        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the PlayArea.
        /// </summary>
        [Serialized]
        [field: Header("Object Follow Settings"), DocumentedByXml, Restricted]
        public ObjectFollower PlayArea { get; protected set; }

        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the Headset.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public ObjectFollower Headset { get; protected set; }

        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the HeadsetOrigin within the PlayArea Alias.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public ObjectFollower HeadsetOrigin { get; protected set; }

        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the Left Controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public ObjectFollower LeftController { get; protected set; }

        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the Right Controller.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public ObjectFollower RightController { get; protected set; }
        #endregion

        #region Velocity Tracker Settings
        /// <summary>
        /// The <see cref="VelocityTrackerProcessor"/> component containing the Headset Velocity Trackers.
        /// </summary>
        [Serialized]
        [field: Header("Velocity Tracker Settings"), DocumentedByXml, Restricted]
        public VelocityTrackerProcessor HeadsetVelocityTrackers { get; protected set; }
        /// <summary>
        /// The <see cref="VelocityTrackerProcessor"/> component containing the Left Controller Velocity Trackers.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public VelocityTrackerProcessor LeftControllerVelocityTrackers { get; protected set; }
        /// <summary>
        /// The <see cref="VelocityTrackerProcessor"/> component containing the Right Controller Velocity Trackers.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public VelocityTrackerProcessor RightControllerVelocityTrackers { get; protected set; }
        #endregion

        #region Other Settings
        /// <summary>
        /// The <see cref="ListContainsRule"/> for defining the valid <see cref="Camera"/> collection.
        /// </summary>
        [Serialized]
        [field: Header("Other Settings"), DocumentedByXml, Restricted]
        public ListContainsRule ValidCameras { get; protected set; }
        /// <summary>
        /// Determines whether to include the CameraRig HeadsetSupplementCameras in the <see cref="ValidCameras"/> collection.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool IncludeHeadsetSupplementCameras { get; set; } = true;
        #endregion

        #region Main Data Cache
        /// <summary>
        /// The current cached Linked Alias Association Collection.
        /// </summary>
        protected LinkedAliasAssociationCollection cachedLinkedAlias;
        /// <summary>
        /// The current cached dominant controller.
        /// </summary>
        protected DeviceDetailsRecord cachedCurrentDominantController;
        /// <summary>
        /// The event handler to run when the bubbled dominant controller is changing is raised.
        /// </summary>
        protected UnityAction<DeviceDetailsRecord> DominantControllerIsChangingEventHandler;
        #endregion

        #region Headset Data Cache
        /// <summary>
        /// The current cached headset tracking begun status.
        /// </summary>
        protected bool cachedHeadsetTrackingBegun;
        /// <summary>
        /// The current cached headset connection status.
        /// </summary>
        protected bool cachedHeadsetConnectionStatus;
        /// <summary>
        /// The current cached headset tracking type.
        /// </summary>
        protected DeviceDetailsRecord.SpatialTrackingType cachedHeadsetSpatialTrackingType;
        /// <summary>
        /// The current cached headset battery charge status.
        /// </summary>
        protected BatteryStatus cachedHeadsetBatteryChargeStatus;

        /// <summary>
        /// The event handler to run when the bubbled headset event for tracking begun is raised.
        /// </summary>
        protected UnityAction HeadsetTrackingBegunEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled headset event for connection changed is raised.
        /// </summary>
        protected UnityAction<bool> HeadsetConnectionChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled headset event for tracking type changed is raised.
        /// </summary>
        protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> HeadsetTrackingTypeChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled headset event for battery charge status changed is raised.
        /// </summary>
        protected UnityAction<BatteryStatus> HeadsetBatteryChargeStatusChangedEventHandler;
        #endregion

        #region Left Controller Data Cache
        /// <summary>
        /// The current cached left controller tracking begun status.
        /// </summary>
        protected bool cachedLeftControllerTrackingBegun;
        /// <summary>
        /// The current cached left controller connection status.
        /// </summary>
        protected bool cachedLeftControllerConnectionStatus;
        /// <summary>
        /// The current cached left controller tracking type.
        /// </summary>
        protected DeviceDetailsRecord.SpatialTrackingType cachedLeftControllerSpatialTrackingType;
        /// <summary>
        /// The current cached left controller battery charge status.
        /// </summary>
        protected BatteryStatus cachedLeftControllerBatteryChargeStatus;

        /// <summary>
        /// The event handler to run when the bubbled left controller event for tracking begun is raised.
        /// </summary>
        protected UnityAction LeftControllerTrackingBegunEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled left controller event for connection changed is raised.
        /// </summary>
        protected UnityAction<bool> LeftControllerConnectionChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled left controller event for tracking type changed is raised.
        /// </summary>
        protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> LeftControllerTrackingTypeChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled left controller event for battery charge status changed is raised.
        /// </summary>
        protected UnityAction<BatteryStatus> LeftControllerBatteryChargeStatusChangedEventHandler;
        #endregion

        #region Right Controller Data Cache
        /// <summary>
        /// The current cached right controller tracking begun status.
        /// </summary>
        protected bool cachedRightControllerTrackingBegun;
        /// <summary>
        /// The current cached right controller connection status.
        /// </summary>
        protected bool cachedRightControllerConnectionStatus;
        /// <summary>
        /// The current cached right controller tracking type.
        /// </summary>
        protected DeviceDetailsRecord.SpatialTrackingType cachedRightControllerSpatialTrackingType;
        /// <summary>
        /// The current cached right controller battery charge status.
        /// </summary>
        protected BatteryStatus cachedRightControllerBatteryChargeStatus;

        /// <summary>
        /// The event handler to run when the bubbled right controller event for tracking begun is raised.
        /// </summary>
        protected UnityAction RightControllerTrackingBegunEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled right controller event for connection changed is raised.
        /// </summary>
        protected UnityAction<bool> RightControllerConnectionChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled right controller event for tracking type changed is raised.
        /// </summary>
        protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> RightControllerTrackingTypeChangedEventHandler;
        /// <summary>
        /// The event handler to run when the bubbled right controller event for battery charge status changed is raised.
        /// </summary>
        protected UnityAction<BatteryStatus> RightControllerBatteryChargeStatusChangedEventHandler;
        #endregion

        /// <summary>
        /// Sets up the TrackedAlias prefab with the specified settings.
        /// </summary>
        public virtual void SetUpCameraRigsConfiguration()
        {
            PlayArea.Targets.RunWhenActiveAndEnabled(() => PlayArea.Targets.Clear());
            foreach (GameObject target in Facade.PlayAreas)
            {
                PlayArea.Targets.RunWhenActiveAndEnabled(() => PlayArea.Targets.Add(target));
            }

            Headset.Sources.RunWhenActiveAndEnabled(() => Headset.Sources.Clear());
            foreach (GameObject source in Facade.Headsets)
            {
                Headset.Sources.RunWhenActiveAndEnabled(() => Headset.Sources.Add(source));
            }

            ValidCameras.Objects.RunWhenActiveAndEnabled(() => ValidCameras.Objects.Clear());
            foreach (Camera headsetCamera in Facade.HeadsetCameras)
            {
                ValidCameras.Objects.RunWhenActiveAndEnabled(() => ValidCameras.Objects.Add(headsetCamera));
            }

            if (IncludeHeadsetSupplementCameras)
            {
                foreach (Camera supplementHeadsetCamera in Facade.HeadsetSupplementCameras)
                {
                    ValidCameras.Objects.RunWhenActiveAndEnabled(() => ValidCameras.Objects.Add(supplementHeadsetCamera));
                }
            }

            HeadsetVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => HeadsetVelocityTrackers.VelocityTrackers.Clear());
            foreach (VelocityTracker velocityTracker in Facade.HeadsetVelocityTrackers)
            {
                HeadsetVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => HeadsetVelocityTrackers.VelocityTrackers.Add(velocityTracker));
            }

            LeftController.Sources.RunWhenActiveAndEnabled(() => LeftController.Sources.Clear());
            foreach (GameObject source in Facade.LeftControllers)
            {
                LeftController.Sources.RunWhenActiveAndEnabled(() => LeftController.Sources.Add(source));
            }

            RightController.Sources.RunWhenActiveAndEnabled(() => RightController.Sources.Clear());
            foreach (GameObject source in Facade.RightControllers)
            {
                RightController.Sources.RunWhenActiveAndEnabled(() => RightController.Sources.Add(source));
            }

            LeftControllerVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => LeftControllerVelocityTrackers.VelocityTrackers.Clear());
            foreach (VelocityTracker velocityTracker in Facade.LeftControllerVelocityTrackers)
            {
                LeftControllerVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => LeftControllerVelocityTrackers.VelocityTrackers.Add(velocityTracker));
            }

            RightControllerVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => RightControllerVelocityTrackers.VelocityTrackers.Clear());
            foreach (VelocityTracker velocityTracker in Facade.RightControllerVelocityTrackers)
            {
                RightControllerVelocityTrackers.VelocityTrackers.RunWhenActiveAndEnabled(() => RightControllerVelocityTrackers.VelocityTrackers.Add(velocityTracker));
            }
        }

        /// <summary>
        /// Notifies when the tracked alias source has changed.
        /// </summary>
        public virtual void NotifyTrackedAliasChanged(GameObject _)
        {
            cachedHeadsetTrackingBegun = false;
            cachedLeftControllerTrackingBegun = false;
            cachedRightControllerTrackingBegun = false;

            SubscribeToDetailsEvents();
            CheckExistingEventStatus();
            Facade.TrackedAliasChanged?.Invoke(Facade.ActiveLinkedAliasAssociation);
        }

        /// <summary>
        /// Notifies that the headset has started being tracked.
        /// </summary>
        public virtual void NotifyHeadsetTrackingBegun()
        {
            Facade.HeadsetTrackingBegun?.Invoke();
        }

        /// <summary>
        /// Notifies that the left controller has started being tracked.
        /// </summary>
        public virtual void NotifyLeftControllerTrackingBegun()
        {
            Facade.LeftControllerTrackingBegun?.Invoke();
        }

        /// <summary>
        /// Notifies that the right controller has started being tracked.
        /// </summary>
        public virtual void NotifyRightControllerTrackingBegun()
        {
            Facade.RightControllerTrackingBegun?.Invoke();
        }

        protected virtual void OnEnable()
        {
            SetUpCameraRigsConfiguration();
        }

        /// <summary>
        /// Checks if the two given values equal and raises the given event with the relevant payload if they are not.
        /// </summary>
        /// <typeparam name="TValue">The variable type to check equality with.</typeparam>
        /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type to raise.</typeparam>
        /// <param name="comparer">The source value to compare from.</param>
        /// <param name="comparator">The target value to compare with.</param>
        /// <param name="output">The event to raise if the two values are not equal.</param>
        protected virtual void CheckAndRaiseEventWithPayload<TValue, TEvent>(ref TValue comparer, TValue comparator, TEvent output) where TEvent : UnityEvent<TValue>, new()
        {
            if (comparator == null)
            {
                return;
            }

            if (!comparator.Equals(comparer))
            {
                output?.Invoke(comparator);
            }

            comparer = comparator;
        }

        /// <summary>
        /// Checks if the two given values equal and raises the given event if they are not.
        /// </summary>
        /// <typeparam name="TValue">The variable type to check equality with.</typeparam>
        /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type to raise.</typeparam>
        /// <param name="comparer">The source value to compare from.</param>
        /// <param name="comparator">The target value to compare with.</param>
        /// <param name="output">The event to raise if the two values are not equal.</param>
        protected virtual void CheckAndRaiseEventWithoutPayload<TValue, TEvent>(ref TValue comparer, TValue comparator, TEvent output) where TEvent : UnityEvent, new()
        {
            if (comparator == null)
            {
                return;
            }

            if (!comparator.Equals(comparer))
            {
                output?.Invoke();
            }

            comparer = comparator;
        }

        /// <summary>
        /// Caches the given new value and raises the given event with the new value as the payload.
        /// </summary>
        /// <typeparam name="TValue">The variable type of the given values.</typeparam>
        /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type to raise.</typeparam>
        /// <param name="newValue">The new value to cache.</param>
        /// <param name="cachedValue">The existing cached value.</param>
        /// <param name="output">The event to raise.</param>
        protected virtual void CacheAndRaiseEventWithPayload<TValue, TEvent>(TValue newValue, ref TValue cachedValue, TEvent output) where TEvent : UnityEvent<TValue>, new()
        {
            cachedValue = newValue;
            output?.Invoke(newValue);
        }

        /// <summary>
        /// Caches the given new value and raises the given event.
        /// </summary>
        /// <typeparam name="TValue">The variable type of the given values.</typeparam>
        /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type to raise.</typeparam>
        /// <param name="newValue">The new value to cache.</param>
        /// <param name="cachedValue">The existing cached value.</param>
        /// <param name="output">The event to raise.</param>
        protected virtual void CacheAndRaiseEventWithoutPayload<TValue, TEvent>(TValue newValue, ref TValue cachedValue, TEvent output) where TEvent : UnityEvent, new()
        {
            cachedValue = newValue;
            output?.Invoke();
        }

        /// <summary>
        /// Check the existing status of the event values and raise a new event if it has changed.
        /// </summary>
        protected virtual void CheckExistingEventStatus()
        {
            if (Facade == null)
            {
                return;
            }

            if (Facade.ActiveDominantControllerRecord != null)
            {
                CheckAndRaiseEventWithPayload(ref cachedCurrentDominantController, Facade.ActiveDominantControllerRecord, Facade.DominantControllerIsChanging);
            }

            if (Facade.ActiveHeadsetDetails != null)
            {
                CheckAndRaiseEventWithoutPayload(ref cachedHeadsetTrackingBegun, Facade.ActiveHeadsetTrackingHasBegun, Facade.HeadsetTrackingBegun);
                CheckAndRaiseEventWithPayload(ref cachedHeadsetConnectionStatus, Facade.ActiveHeadsetIsConnected, Facade.HeadsetConnectionStatusChanged);
                CheckAndRaiseEventWithPayload(ref cachedHeadsetSpatialTrackingType, Facade.ActiveHeadsetTrackingType, Facade.HeadsetTrackingTypeChanged);
                CheckAndRaiseEventWithPayload(ref cachedHeadsetBatteryChargeStatus, Facade.ActiveHeadsetBatteryChargeStatus, Facade.HeadsetBatteryChargeStatusChanged);
            }

            if (Facade.ActiveLeftControllerDetails != null)
            {
                CheckAndRaiseEventWithoutPayload(ref cachedLeftControllerTrackingBegun, Facade.ActiveLeftControllerTrackingHasBegun, Facade.LeftControllerTrackingBegun);
                CheckAndRaiseEventWithPayload(ref cachedLeftControllerConnectionStatus, Facade.ActiveLeftControllerIsConnected, Facade.LeftControllerConnectionStatusChanged);
                CheckAndRaiseEventWithPayload(ref cachedLeftControllerSpatialTrackingType, Facade.ActiveLeftControllerTrackingType, Facade.LeftControllerTrackingTypeChanged);
                CheckAndRaiseEventWithPayload(ref cachedLeftControllerBatteryChargeStatus, Facade.ActiveLeftControllerBatteryChargeStatus, Facade.LeftControllerBatteryChargeStatusChanged);
            }

            if (Facade.ActiveRightControllerDetails != null)
            {
                CheckAndRaiseEventWithoutPayload(ref cachedRightControllerTrackingBegun, Facade.ActiveRightControllerTrackingHasBegun, Facade.RightControllerTrackingBegun);
                CheckAndRaiseEventWithPayload(ref cachedRightControllerConnectionStatus, Facade.ActiveRightControllerIsConnected, Facade.RightControllerConnectionStatusChanged);
                CheckAndRaiseEventWithPayload(ref cachedRightControllerSpatialTrackingType, Facade.ActiveRightControllerTrackingType, Facade.RightControllerTrackingTypeChanged);
                CheckAndRaiseEventWithPayload(ref cachedRightControllerBatteryChargeStatus, Facade.ActiveRightControllerBatteryChargeStatus, Facade.RightControllerBatteryChargeStatusChanged);
            }
        }

        /// <summary>
        /// Subscribe to the events of each <see cref="DeviceDetailsRecord"/>.
        /// </summary>
        protected virtual void SubscribeToDetailsEvents()
        {
            if (cachedLinkedAlias != null && cachedLinkedAlias != Facade.ActiveLinkedAliasAssociation)
            {
                UnsubscribeToDetailsEvents();
            }

            if (Facade.ActiveLinkedAliasAssociation != null && Facade.ActiveLinkedAliasAssociation.DominantController != null)
            {
                DominantControllerIsChangingEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedCurrentDominantController, Facade.DominantControllerIsChanging);
                Facade.ActiveLinkedAliasAssociation.DominantController.IsChanging.AddListener(DominantControllerIsChangingEventHandler);
            }

            if (Facade.ActiveLinkedAliasAssociation != null && Facade.ActiveLinkedAliasAssociation.HeadsetDeviceDetails != null)
            {
                HeadsetTrackingBegunEventHandler = () => CacheAndRaiseEventWithoutPayload(true, ref cachedHeadsetTrackingBegun, Facade.HeadsetTrackingBegun);
                HeadsetConnectionChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedHeadsetConnectionStatus, Facade.HeadsetConnectionStatusChanged);
                HeadsetTrackingTypeChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedHeadsetSpatialTrackingType, Facade.HeadsetTrackingTypeChanged);
                HeadsetBatteryChargeStatusChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedHeadsetBatteryChargeStatus, Facade.HeadsetBatteryChargeStatusChanged);

                Facade.ActiveLinkedAliasAssociation.HeadsetDeviceDetails.TrackingBegun.AddListener(HeadsetTrackingBegunEventHandler);
                Facade.ActiveLinkedAliasAssociation.HeadsetDeviceDetails.ConnectionStatusChanged.AddListener(HeadsetConnectionChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.HeadsetDeviceDetails.TrackingTypeChanged.AddListener(HeadsetTrackingTypeChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.HeadsetDeviceDetails.BatteryChargeStatusChanged.AddListener(HeadsetBatteryChargeStatusChangedEventHandler);
            }

            if (Facade.ActiveLinkedAliasAssociation != null && Facade.ActiveLinkedAliasAssociation.LeftControllerDeviceDetails != null)
            {
                LeftControllerTrackingBegunEventHandler = () => CacheAndRaiseEventWithoutPayload(true, ref cachedLeftControllerTrackingBegun, Facade.LeftControllerTrackingBegun);
                LeftControllerConnectionChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedLeftControllerConnectionStatus, Facade.LeftControllerConnectionStatusChanged);
                LeftControllerTrackingTypeChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedLeftControllerSpatialTrackingType, Facade.LeftControllerTrackingTypeChanged);
                LeftControllerBatteryChargeStatusChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedLeftControllerBatteryChargeStatus, Facade.LeftControllerBatteryChargeStatusChanged);

                Facade.ActiveLinkedAliasAssociation.LeftControllerDeviceDetails.TrackingBegun.AddListener(LeftControllerTrackingBegunEventHandler);
                Facade.ActiveLinkedAliasAssociation.LeftControllerDeviceDetails.ConnectionStatusChanged.AddListener(LeftControllerConnectionChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.LeftControllerDeviceDetails.TrackingTypeChanged.AddListener(LeftControllerTrackingTypeChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.LeftControllerDeviceDetails.BatteryChargeStatusChanged.AddListener(LeftControllerBatteryChargeStatusChangedEventHandler);
            }

            if (Facade.ActiveLinkedAliasAssociation != null && Facade.ActiveLinkedAliasAssociation.RightControllerDeviceDetails != null)
            {
                RightControllerTrackingBegunEventHandler = () => CacheAndRaiseEventWithoutPayload(true, ref cachedRightControllerTrackingBegun, Facade.RightControllerTrackingBegun);
                RightControllerConnectionChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedRightControllerConnectionStatus, Facade.RightControllerConnectionStatusChanged);
                RightControllerTrackingTypeChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedRightControllerSpatialTrackingType, Facade.RightControllerTrackingTypeChanged);
                RightControllerBatteryChargeStatusChangedEventHandler = (newValue) => CacheAndRaiseEventWithPayload(newValue, ref cachedRightControllerBatteryChargeStatus, Facade.RightControllerBatteryChargeStatusChanged);

                Facade.ActiveLinkedAliasAssociation.RightControllerDeviceDetails.TrackingBegun.AddListener(RightControllerTrackingBegunEventHandler);
                Facade.ActiveLinkedAliasAssociation.RightControllerDeviceDetails.ConnectionStatusChanged.AddListener(RightControllerConnectionChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.RightControllerDeviceDetails.TrackingTypeChanged.AddListener(RightControllerTrackingTypeChangedEventHandler);
                Facade.ActiveLinkedAliasAssociation.RightControllerDeviceDetails.BatteryChargeStatusChanged.AddListener(RightControllerBatteryChargeStatusChangedEventHandler);
            }

            cachedLinkedAlias = Facade.ActiveLinkedAliasAssociation;
        }

        /// <summary>
        /// Unsubscribes from the events of each <see cref="DeviceDetailsRecord"/>.
        /// </summary>
        protected virtual void UnsubscribeToDetailsEvents()
        {
            if (cachedLinkedAlias != null && cachedLinkedAlias.DominantController != null)
            {
                cachedLinkedAlias.DominantController.IsChanging.RemoveListener(DominantControllerIsChangingEventHandler);
            }

            if (cachedLinkedAlias != null && cachedLinkedAlias.HeadsetDeviceDetails != null)
            {
                cachedLinkedAlias.HeadsetDeviceDetails.TrackingBegun.RemoveListener(HeadsetTrackingBegunEventHandler);
                cachedLinkedAlias.HeadsetDeviceDetails.ConnectionStatusChanged.RemoveListener(HeadsetConnectionChangedEventHandler);
                cachedLinkedAlias.HeadsetDeviceDetails.TrackingTypeChanged.RemoveListener(HeadsetTrackingTypeChangedEventHandler);
                cachedLinkedAlias.HeadsetDeviceDetails.BatteryChargeStatusChanged.RemoveListener(HeadsetBatteryChargeStatusChangedEventHandler);
            }

            if (cachedLinkedAlias != null && cachedLinkedAlias.LeftControllerDeviceDetails != null)
            {
                cachedLinkedAlias.LeftControllerDeviceDetails.TrackingBegun.RemoveListener(LeftControllerTrackingBegunEventHandler);
                cachedLinkedAlias.LeftControllerDeviceDetails.ConnectionStatusChanged.RemoveListener(LeftControllerConnectionChangedEventHandler);
                cachedLinkedAlias.LeftControllerDeviceDetails.TrackingTypeChanged.RemoveListener(LeftControllerTrackingTypeChangedEventHandler);
                cachedLinkedAlias.LeftControllerDeviceDetails.BatteryChargeStatusChanged.RemoveListener(LeftControllerBatteryChargeStatusChangedEventHandler);
            }

            if (cachedLinkedAlias != null && cachedLinkedAlias.RightControllerDeviceDetails != null)
            {
                cachedLinkedAlias.RightControllerDeviceDetails.TrackingBegun.RemoveListener(RightControllerTrackingBegunEventHandler);
                cachedLinkedAlias.RightControllerDeviceDetails.ConnectionStatusChanged.RemoveListener(RightControllerConnectionChangedEventHandler);
                cachedLinkedAlias.RightControllerDeviceDetails.TrackingTypeChanged.RemoveListener(RightControllerTrackingTypeChangedEventHandler);
                cachedLinkedAlias.RightControllerDeviceDetails.BatteryChargeStatusChanged.RemoveListener(RightControllerBatteryChargeStatusChangedEventHandler);
            }

            cachedLinkedAlias = null;
        }
    }
}