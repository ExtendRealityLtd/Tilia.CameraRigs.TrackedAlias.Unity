namespace Tilia.CameraRigs.TrackedAlias
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Haptics;
    using Zinnia.Haptics.Collection;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Tracking.CameraRig.Collection;
    using Zinnia.Tracking.Follow;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// The public interface into the Tracked Alias Prefab.
    /// </summary>
    public class TrackedAliasFacade : MonoBehaviour
    {
        /// <summary>
        /// Defines the event with the <see cref="LinkedAliasAssociationCollection"/>.
        /// </summary>
        [Serializable]
        public class LinkedAliasAssociationCollectionUnityEvent : UnityEvent<LinkedAliasAssociationCollection> { }

        #region Tracked Alias Settings
        /// <summary>
        /// The associated CameraRigs to track.
        /// </summary>
        [Serialized]
        [field: Header("Tracked Alias Settings"), DocumentedByXml]
        public LinkedAliasAssociationCollectionObservableList CameraRigs { get; set; }
        #endregion

        #region Tracking Events
        /// <summary>
        /// Emitted when the tracked alias is about to change.
        /// </summary>
        [Header("Tracking Events")]
        public LinkedAliasAssociationCollectionUnityEvent TrackedAliasChanged = new LinkedAliasAssociationCollectionUnityEvent();
        /// <summary>
        /// Emitted when the headset starts tracking for the first time.
        /// </summary>
        public UnityEvent HeadsetTrackingBegun = new UnityEvent();
        /// <summary>
        /// Emitted when the left controller starts tracking for the first time.
        /// </summary>
        public UnityEvent LeftControllerTrackingBegun = new UnityEvent();
        /// <summary>
        /// Emitted when the right controller starts tracking for the first time.
        /// </summary>
        public UnityEvent RightControllerTrackingBegun = new UnityEvent();
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public TrackedAliasConfigurator Configuration { get; protected set; }
        #endregion

        public LinkedAliasAssociationCollection ActiveLinkedAliasAssociation => GetFirstActiveLinkedAliasAssociationCollection(CameraRigs.NonSubscribableElements);
        /// <summary>
        /// Retrieves the active PlayArea that the TrackedAlias is using.
        /// </summary>
        public GameObject ActivePlayArea => GetFirstActiveGameObject(PlayAreas);
        /// <summary>
        /// Retrieves the active Headset that the TrackedAlias is using.
        /// </summary>
        public GameObject ActiveHeadset => GetFirstActiveGameObject(Headsets);
        /// <summary>
        /// Retrieves the active Headset Camera that the TrackedAlias is using.
        /// </summary>
        public Camera ActiveHeadsetCamera => GetFirstActiveCamera(HeadsetCameras);
        /// <summary>
        /// Retrieves the active Headset Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public VelocityTracker ActiveHeadsetVelocity => GetFirstActiveVelocityTracker(HeadsetVelocityTrackers);
        /// <summary>
        /// Retrieves the active Left Controller that the TrackedAlias is using.
        /// </summary>
        public GameObject ActiveLeftController => GetFirstActiveGameObject(LeftControllers);
        /// <summary>
        /// Retrieves the active Left Controller Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public VelocityTracker ActiveLeftControllerVelocity => GetFirstActiveVelocityTracker(LeftControllerVelocityTrackers);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Process that the TrackedAlias is using.
        /// </summary>
        public HapticProcess ActiveLeftHapticProcess => GetFirstActiveHapticProcess(LeftControllerHapticProcesses);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Profiles that the TrackedAlias is using.
        /// </summary>
        public HapticProcessObservableList ActiveLeftHapticProfiles => GetFirstActiveHapticProfile(LeftControllerHapticProfiles);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Profile that has been most recently used.
        /// </summary>
        public HapticProcess ActiveLeftHapticProfile { get; protected set; }
        /// <summary>
        /// Retrieves the active Right Controller that the TrackedAlias is using.
        /// </summary>
        public GameObject ActiveRightController => GetFirstActiveGameObject(RightControllers);
        /// <summary>
        /// Retrieves the active Right Controller Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public VelocityTracker ActiveRightControllerVelocity => GetFirstActiveVelocityTracker(RightControllerVelocityTrackers);
        /// <summary>
        /// Retrieves the active Right Controller Haptic Process that the TrackedAlias is using.
        /// </summary>
        public HapticProcess ActiveRightHapticProcess => GetFirstActiveHapticProcess(RightControllerHapticProcesses);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Profiles that the TrackedAlias is using.
        /// </summary>
        public HapticProcessObservableList ActiveRightHapticProfiles => GetFirstActiveHapticProfile(RightControllerHapticProfiles);
        /// <summary>
        /// Retrieves the active Right Controller Haptic Profile that has been most recently used.
        /// </summary>
        public HapticProcess ActiveRightHapticProfile { get; protected set; }

        /// <summary>
        /// Retrieves all of the linked CameraRig PlayAreas.
        /// </summary>
        public IEnumerable<GameObject> PlayAreas
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject playArea = cameraRig.PlayArea;
                    if (playArea != null)
                    {
                        yield return playArea;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headsets.
        /// </summary>
        public IEnumerable<GameObject> Headsets
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject headset = cameraRig.Headset;
                    if (headset != null)
                    {
                        yield return headset;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headset Cameras.
        /// </summary>
        public IEnumerable<Camera> HeadsetCameras
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    Camera headsetCamera = cameraRig.HeadsetCamera;
                    if (headsetCamera != null)
                    {
                        yield return headsetCamera;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headset Velocity Trackers.
        /// </summary>
        public IEnumerable<VelocityTracker> HeadsetVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker headsetVelocityTracker = cameraRig.HeadsetVelocityTracker;
                    if (headsetVelocityTracker != null)
                    {
                        yield return headsetVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Supplement Headset Camera.
        /// </summary>
        public IEnumerable<Camera> HeadsetSupplementCameras
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    if (cameraRig.SupplementHeadsetCameras != null)
                    {
                        foreach (Camera headsetCamera in cameraRig.SupplementHeadsetCameras.NonSubscribableElements)
                        {
                            yield return headsetCamera;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controllers.
        /// </summary>
        public IEnumerable<GameObject> LeftControllers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject leftController = cameraRig.LeftController;
                    if (leftController != null)
                    {
                        yield return leftController;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controllers.
        /// </summary>
        public IEnumerable<GameObject> RightControllers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject rightController = cameraRig.RightController;
                    if (rightController != null)
                    {
                        yield return rightController;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Velocity Trackers.
        /// </summary>
        public IEnumerable<VelocityTracker> LeftControllerVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker leftControllerVelocityTracker = cameraRig.LeftControllerVelocityTracker;
                    if (leftControllerVelocityTracker != null)
                    {
                        yield return leftControllerVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Velocity Trackers.
        /// </summary>
        public IEnumerable<VelocityTracker> RightControllerVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker rightControllerVelocityTracker = cameraRig.RightControllerVelocityTracker;
                    if (rightControllerVelocityTracker != null)
                    {
                        yield return rightControllerVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Haptic Processes.
        /// </summary>
        public IEnumerable<HapticProcess> LeftControllerHapticProcesses
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcess leftControllerHapticProcess = cameraRig.LeftControllerHapticProcess;
                    if (leftControllerHapticProcess != null)
                    {
                        yield return leftControllerHapticProcess;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Haptic Processes.
        /// </summary>
        public IEnumerable<HapticProcess> RightControllerHapticProcesses
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcess rightControllerHapticProcess = cameraRig.RightControllerHapticProcess;
                    if (rightControllerHapticProcess != null)
                    {
                        yield return rightControllerHapticProcess;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Haptic Profiles.
        /// </summary>
        public IEnumerable<HapticProcessObservableList> LeftControllerHapticProfiles
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcessObservableList leftControllerHapticProfiles = cameraRig.LeftControllerHapticProfiles;
                    if (leftControllerHapticProfiles != null)
                    {
                        yield return leftControllerHapticProfiles;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Haptic Processes.
        /// </summary>
        public IEnumerable<HapticProcessObservableList> RightControllerHapticProfiles
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcessObservableList rightControllerHapticProfiles = cameraRig.RightControllerHapticProfiles;
                    if (rightControllerHapticProfiles != null)
                    {
                        yield return rightControllerHapticProfiles;
                    }
                }
            }
        }
        /// <summary>
        /// The alias follower for the PlayArea.
        /// </summary>
        public ObjectFollower PlayAreaAlias => Configuration.PlayArea;
        /// <summary>
        /// The alias follower for the Headset.
        /// </summary>
        public ObjectFollower HeadsetAlias => Configuration.Headset;
        /// <summary>
        /// The alias follower for the Headset Origin within the <see cref="PlayAreaAlias"/>.
        /// </summary>
        public ObjectFollower HeadsetOriginAlias => Configuration.HeadsetOrigin;
        /// <summary>
        /// The alias follower for the LeftController.
        /// </summary>
        public ObjectFollower LeftControllerAlias => Configuration.LeftController;
        /// <summary>
        /// The alias follower for the RightController.
        /// </summary>
        public ObjectFollower RightControllerAlias => Configuration.RightController;

        /// <summary>
        /// Begins the haptic process on the Left Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void BeginHapticProcessOnLeftController()
        {
            if (ActiveLeftHapticProcess == null)
            {
                return;
            }

            ActiveLeftHapticProcess.Begin();
        }

        /// <summary>
        /// Begins a haptic process on the Left Controller using the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to use.</param>
        public virtual void BeginHapticProcessOnLeftController(int profileIndex)
        {
            ActiveLeftHapticProfile = BeginHapticProfile(ActiveLeftHapticProfiles, profileIndex);
        }

        /// <summary>
        /// Begins the haptic process on the Right Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void BeginHapticProcessOnRightController()
        {
            if (ActiveRightHapticProcess == null)
            {
                return;
            }

            ActiveRightHapticProcess.Begin();
        }

        /// <summary>
        /// Begins a haptic process on the Right Controller using the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to use.</param>
        public virtual void BeginHapticProcessOnRightController(int profileIndex)
        {
            ActiveRightHapticProfile = BeginHapticProfile(ActiveRightHapticProfiles, profileIndex);
        }

        /// <summary>
        /// Cancels all haptic process currently running on the Left Controller.
        /// </summary>
        public virtual void CancelAllHapticsOnLeftController()
        {
            CancelHapticProcessOnLeftController();
            CancelActiveHapticProfileOnLeftController();

            if (ActiveLeftHapticProfiles == null)
            {
                return;
            }

            foreach (HapticProcess process in ActiveLeftHapticProfiles.NonSubscribableElements)
            {
                process.Cancel();
            }
        }

        /// <summary>
        /// Cancels any haptic process currently running on the Left Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void CancelHapticProcessOnLeftController()
        {
            if (ActiveLeftHapticProcess == null)
            {
                return;
            }

            ActiveLeftHapticProcess.Cancel();
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Left Controller for the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to cancel.</param>
        public virtual void CancelHapticProcessOnLeftController(int profileIndex)
        {
            CancelHapticProfile(ActiveLeftHapticProfiles, profileIndex);
            ActiveLeftHapticProfile = null;
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Left Controller for the current haptic profile.
        /// </summary>
        public virtual void CancelActiveHapticProfileOnLeftController()
        {
            if (ActiveLeftHapticProfile == null)
            {
                return;
            }

            ActiveLeftHapticProfile.Cancel();
        }

        /// <summary>
        /// Cancels all haptic process currently running on the Right Controller.
        /// </summary>
        public virtual void CancelAllHapticsOnRightController()
        {
            CancelHapticProcessOnRightController();
            CancelActiveHapticProfileOnRightController();

            if (ActiveRightHapticProfiles == null)
            {
                return;
            }

            foreach (HapticProcess process in ActiveRightHapticProfiles.NonSubscribableElements)
            {
                process.Cancel();
            }
        }

        /// <summary>
        /// Cancels any haptic process currently running on the Right Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void CancelHapticProcessOnRightController()
        {
            if (ActiveRightHapticProcess == null)
            {
                return;
            }

            ActiveRightHapticProcess.Cancel();
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Right Controller for the current haptic profile.
        /// </summary>
        public virtual void CancelActiveHapticProfileOnRightController()
        {
            if (ActiveRightHapticProfile == null)
            {
                return;
            }

            ActiveRightHapticProfile.Cancel();
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Right Controller for the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to cancel.</param>
        public virtual void CancelHapticProcessOnRightController(int profileIndex)
        {
            CancelHapticProfile(ActiveRightHapticProfiles, profileIndex);
            ActiveRightHapticProfile = null;
        }

        protected virtual void OnEnable()
        {
            SubscribeToCameraRigsEvents();
        }

        protected virtual void OnDisable()
        {
            UnsubscribeFromCameraRigsEvents();
        }

        /// <summary>
        /// Subscribes to the events on the current <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void SubscribeToCameraRigsEvents()
        {
            if (CameraRigs == null)
            {
                return;
            }

            CameraRigs.Added.AddListener(OnCameraRigAdded);
            CameraRigs.Removed.AddListener(OnCameraRigRemoved);
        }

        /// <summary>
        /// Unsubscribes from the events on the current <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void UnsubscribeFromCameraRigsEvents()
        {
            if (CameraRigs == null)
            {
                return;
            }

            CameraRigs.Added.RemoveListener(OnCameraRigAdded);
            CameraRigs.Removed.RemoveListener(OnCameraRigRemoved);
        }

        /// <summary>
        /// Occurs when an item is added to the <see cref="CameraRigs"/> collection.
        /// </summary>
        /// <param name="cameraRig">The added element.</param>
        protected virtual void OnCameraRigAdded(LinkedAliasAssociationCollection cameraRig)
        {
            RefreshCameraRigsConfiguration();
        }

        /// <summary>
        /// Occurs when an item is removed from the <see cref="CameraRigs"/> collection.
        /// </summary>
        /// <param name="cameraRig">The removed element.</param>
        protected virtual void OnCameraRigRemoved(LinkedAliasAssociationCollection cameraRig)
        {
            RefreshCameraRigsConfiguration();
        }

        /// <summary>
        /// Refreshes any changes made to the <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void RefreshCameraRigsConfiguration()
        {
            Configuration.SetUpCameraRigsConfiguration();
        }

        /// <summary>
        /// Gets the first active <see cref="LinkedAliasAssociationCollection"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual LinkedAliasAssociationCollection GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection> collection)
        {
            foreach (LinkedAliasAssociationCollection element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="GameObject"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual GameObject GetFirstActiveGameObject(IEnumerable<GameObject> collection)
        {
            foreach (GameObject element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="Camera"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual Camera GetFirstActiveCamera(IEnumerable<Camera> collection)
        {
            foreach (Camera element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="VelocityTracker"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual VelocityTracker GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker> collection)
        {
            foreach (VelocityTracker element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="HapticProcess"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual HapticProcess GetFirstActiveHapticProcess(IEnumerable<HapticProcess> collection)
        {
            foreach (HapticProcess element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active profile found in the given haptic profile collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active profile collection in the collection.</returns>
        protected virtual HapticProcessObservableList GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList> collection)
        {
            foreach (HapticProcessObservableList list in collection)
            {
                foreach (HapticProcess element in list.NonSubscribableElements)
                {
                    if (element.gameObject.activeInHierarchy)
                    {
                        return list;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Begins the haptic process for the specified profile.
        /// </summary>
        /// <param name="processes">The processes to begin.</param>
        /// <param name="profileIndex">The index of the process to use.</param>
        /// <returns>The haptic process being accessed.</returns>
        protected virtual HapticProcess BeginHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            if (!IsValidHapticProfile(processes, profileIndex))
            {
                return null;
            }

            processes.NonSubscribableElements[profileIndex].Begin();
            return processes.NonSubscribableElements[profileIndex];
        }

        /// <summary>
        /// Cancels the haptic process for the specified profile.
        /// </summary>
        /// <param name="processes">The processes to cancel.</param>
        /// <param name="profileIndex">The index of the process to use.</param>
        /// <returns>The haptic process being accessed.</returns>
        protected virtual HapticProcess CancelHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            if (!IsValidHapticProfile(processes, profileIndex))
            {
                return null;
            }

            processes.NonSubscribableElements[profileIndex].Cancel();
            return processes.NonSubscribableElements[profileIndex];
        }

        /// <summary>
        /// Determines whether the haptic profile is valid for the given index.
        /// </summary>
        /// <param name="processes">The processes to check.</param>
        /// <param name="profileIndex">The index of the process to check validity on.</param>
        /// <returns>Whether the given index is a valid profile.</returns>
        protected virtual bool IsValidHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            return processes != null && profileIndex >= 0 && profileIndex < processes.NonSubscribableElements.Count;
        }

        /// <summary>
        /// Called before <see cref="CameraRigs"/> has been changed.
        /// </summary>
        [CalledBeforeChangeOf(nameof(CameraRigs))]
        protected virtual void OnBeforeCameraRigsChange()
        {
            UnsubscribeFromCameraRigsEvents();
        }

        /// <summary>
        /// Called after <see cref="CameraRigs"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(CameraRigs))]
        protected virtual void OnAfterCameraRigsChange()
        {
            SubscribeToCameraRigsEvents();
            RefreshCameraRigsConfiguration();
        }
    }
}
