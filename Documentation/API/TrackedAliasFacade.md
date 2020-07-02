# Class TrackedAliasFacade

The public interface into the Tracked Alias Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [HeadsetTrackingBegun]
  * [LeftControllerTrackingBegun]
  * [RightControllerTrackingBegun]
  * [TrackedAliasChanged]
* [Properties]
  * [ActiveHeadset]
  * [ActiveHeadsetCamera]
  * [ActiveHeadsetVelocity]
  * [ActiveLeftController]
  * [ActiveLeftControllerVelocity]
  * [ActiveLeftHapticProcess]
  * [ActiveLinkedAliasAssociation]
  * [ActivePlayArea]
  * [ActiveRightController]
  * [ActiveRightControllerVelocity]
  * [ActiveRightHapticProcess]
  * [CameraRigs]
  * [Configuration]
  * [HeadsetAlias]
  * [HeadsetCameras]
  * [HeadsetOriginAlias]
  * [Headsets]
  * [HeadsetSupplementCameras]
  * [HeadsetVelocityTrackers]
  * [LeftControllerAlias]
  * [LeftControllerHapticProcesses]
  * [LeftControllers]
  * [LeftControllerVelocityTrackers]
  * [PlayAreaAlias]
  * [PlayAreas]
  * [RightControllerAlias]
  * [RightControllerHapticProcesses]
  * [RightControllers]
  * [RightControllerVelocityTrackers]
* [Methods]
  * [GetFirstActiveCamera(IEnumerable<Camera>)]
  * [GetFirstActiveGameObject(IEnumerable<GameObject>)]
  * [GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)]
  * [GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)]
  * [GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)]
  * [OnAfterCameraRigsChange()]
  * [OnBeforeCameraRigsChange()]
  * [OnCameraRigAdded(LinkedAliasAssociationCollection)]
  * [OnCameraRigRemoved(LinkedAliasAssociationCollection)]
  * [OnDisable()]
  * [OnEnable()]
  * [RefreshCameraRigsConfiguration()]
  * [SubscribeToCameraRigsEvents()]
  * [UnsubscribeFromCameraRigsEvents()]

## Details

##### Inheritance

* System.Object
* TrackedAliasFacade

##### Namespace

* [Tilia.CameraRigs.TrackedAlias]

##### Syntax

```
public class TrackedAliasFacade : MonoBehaviour
```

### Fields

#### HeadsetTrackingBegun

Emitted when the headset starts tracking for the first time.

##### Declaration

```
public UnityEvent HeadsetTrackingBegun
```

#### LeftControllerTrackingBegun

Emitted when the left controller starts tracking for the first time.

##### Declaration

```
public UnityEvent LeftControllerTrackingBegun
```

#### RightControllerTrackingBegun

Emitted when the right controller starts tracking for the first time.

##### Declaration

```
public UnityEvent RightControllerTrackingBegun
```

#### TrackedAliasChanged

Emitted when the tracked alias is about to change.

##### Declaration

```
public TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent TrackedAliasChanged
```

### Properties

#### ActiveHeadset

Retrieves the active Headset that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveHeadset { get; }
```

#### ActiveHeadsetCamera

Retrieves the active Headset Camera that the TrackedAlias is using.

##### Declaration

```
public Camera ActiveHeadsetCamera { get; }
```

#### ActiveHeadsetVelocity

Retrieves the active Headset Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveHeadsetVelocity { get; }
```

#### ActiveLeftController

Retrieves the active Left Controller that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveLeftController { get; }
```

#### ActiveLeftControllerVelocity

Retrieves the active Left Controller Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveLeftControllerVelocity { get; }
```

#### ActiveLeftHapticProcess

Retrieves the active Left Controller Haptic Process that the TrackedAlias is using.

##### Declaration

```
public HapticProcess ActiveLeftHapticProcess { get; }
```

#### ActiveLinkedAliasAssociation

##### Declaration

```
public LinkedAliasAssociationCollection ActiveLinkedAliasAssociation { get; }
```

#### ActivePlayArea

Retrieves the active PlayArea that the TrackedAlias is using.

##### Declaration

```
public GameObject ActivePlayArea { get; }
```

#### ActiveRightController

Retrieves the active Right Controller that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveRightController { get; }
```

#### ActiveRightControllerVelocity

Retrieves the active Right Controller Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveRightControllerVelocity { get; }
```

#### ActiveRightHapticProcess

Retrieves the active Right Controller Haptic Process that the TrackedAlias is using.

##### Declaration

```
public HapticProcess ActiveRightHapticProcess { get; }
```

#### CameraRigs

The associated CameraRigs to track.

##### Declaration

```
public LinkedAliasAssociationCollectionObservableList CameraRigs { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public TrackedAliasConfigurator Configuration { get; protected set; }
```

#### HeadsetAlias

The alias follower for the Headset.

##### Declaration

```
public ObjectFollower HeadsetAlias { get; }
```

#### HeadsetCameras

Retrieves all of the linked CameraRig Headset Cameras.

##### Declaration

```
public IEnumerable<Camera> HeadsetCameras { get; }
```

#### HeadsetOriginAlias

The alias follower for the Headset Origin within the [PlayAreaAlias].

##### Declaration

```
public ObjectFollower HeadsetOriginAlias { get; }
```

#### Headsets

Retrieves all of the linked CameraRig Headsets.

##### Declaration

```
public IEnumerable<GameObject> Headsets { get; }
```

#### HeadsetSupplementCameras

Retrieves all of the linked CameraRig Supplement Headset Camera.

##### Declaration

```
public IEnumerable<Camera> HeadsetSupplementCameras { get; }
```

#### HeadsetVelocityTrackers

Retrieves all of the linked CameraRig Headset Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> HeadsetVelocityTrackers { get; }
```

#### LeftControllerAlias

The alias follower for the LeftController.

##### Declaration

```
public ObjectFollower LeftControllerAlias { get; }
```

#### LeftControllerHapticProcesses

Retrieves all of the linked CameraRig Left Controller Haptic Processes.

##### Declaration

```
public IEnumerable<HapticProcess> LeftControllerHapticProcesses { get; }
```

#### LeftControllers

Retrieves all of the linked CameraRig Left Controllers.

##### Declaration

```
public IEnumerable<GameObject> LeftControllers { get; }
```

#### LeftControllerVelocityTrackers

Retrieves all of the linked CameraRig Left Controller Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> LeftControllerVelocityTrackers { get; }
```

#### PlayAreaAlias

The alias follower for the PlayArea.

##### Declaration

```
public ObjectFollower PlayAreaAlias { get; }
```

#### PlayAreas

Retrieves all of the linked CameraRig PlayAreas.

##### Declaration

```
public IEnumerable<GameObject> PlayAreas { get; }
```

#### RightControllerAlias

The alias follower for the RightController.

##### Declaration

```
public ObjectFollower RightControllerAlias { get; }
```

#### RightControllerHapticProcesses

Retrieves all of the linked CameraRig Right Controller Haptic Processes.

##### Declaration

```
public IEnumerable<HapticProcess> RightControllerHapticProcesses { get; }
```

#### RightControllers

Retrieves all of the linked CameraRig Right Controllers.

##### Declaration

```
public IEnumerable<GameObject> RightControllers { get; }
```

#### RightControllerVelocityTrackers

Retrieves all of the linked CameraRig Right Controller Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> RightControllerVelocityTrackers { get; }
```

### Methods

#### GetFirstActiveCamera(IEnumerable<Camera>)

Gets the first active Camera found in the given collection.

##### Declaration

```
protected virtual Camera GetFirstActiveCamera(IEnumerable<Camera> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<Camera\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| Camera | The found first active element in the collection. |

#### GetFirstActiveGameObject(IEnumerable<GameObject>)

Gets the first active GameObject found in the given collection.

##### Declaration

```
protected virtual GameObject GetFirstActiveGameObject(IEnumerable<GameObject> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<GameObject\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| GameObject | The found first active element in the collection. |

#### GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)

Gets the first active HapticProcess found in the given collection.

##### Declaration

```
protected virtual HapticProcess GetFirstActiveHapticProcess(IEnumerable<HapticProcess> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<HapticProcess\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| HapticProcess | The found first active element in the collection. |

#### GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)

Gets the first active LinkedAliasAssociationCollection found in the given collection.

##### Declaration

```
protected virtual LinkedAliasAssociationCollection GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<LinkedAliasAssociationCollection\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| LinkedAliasAssociationCollection | The found first active element in the collection. |

#### GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)

Gets the first active VelocityTracker found in the given collection.

##### Declaration

```
protected virtual VelocityTracker GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<VelocityTracker\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| VelocityTracker | The found first active element in the collection. |

#### OnAfterCameraRigsChange()

Called after [CameraRigs] has been changed.

##### Declaration

```
protected virtual void OnAfterCameraRigsChange()
```

#### OnBeforeCameraRigsChange()

Called before [CameraRigs] has been changed.

##### Declaration

```
protected virtual void OnBeforeCameraRigsChange()
```

#### OnCameraRigAdded(LinkedAliasAssociationCollection)

Occurs when an item is added to the [CameraRigs] collection.

##### Declaration

```
protected virtual void OnCameraRigAdded(LinkedAliasAssociationCollection cameraRig)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| LinkedAliasAssociationCollection | cameraRig | The added element. |

#### OnCameraRigRemoved(LinkedAliasAssociationCollection)

Occurs when an item is removed from the [CameraRigs] collection.

##### Declaration

```
protected virtual void OnCameraRigRemoved(LinkedAliasAssociationCollection cameraRig)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| LinkedAliasAssociationCollection | cameraRig | The removed element. |

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### RefreshCameraRigsConfiguration()

Refreshes any changes made to the [CameraRigs] collection.

##### Declaration

```
protected virtual void RefreshCameraRigsConfiguration()
```

#### SubscribeToCameraRigsEvents()

Subscribes to the events on the current [CameraRigs] collection.

##### Declaration

```
protected virtual void SubscribeToCameraRigsEvents()
```

#### UnsubscribeFromCameraRigsEvents()

Unsubscribes from the events on the current [CameraRigs] collection.

##### Declaration

```
protected virtual void UnsubscribeFromCameraRigsEvents()
```

[Tilia.CameraRigs.TrackedAlias]: README.md
[TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent]: TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent.md
[TrackedAliasConfigurator]: TrackedAliasConfigurator.md
[PlayAreaAlias]: TrackedAliasFacade.md#PlayAreaAlias
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[HeadsetTrackingBegun]: #HeadsetTrackingBegun
[LeftControllerTrackingBegun]: #LeftControllerTrackingBegun
[RightControllerTrackingBegun]: #RightControllerTrackingBegun
[TrackedAliasChanged]: #TrackedAliasChanged
[Properties]: #Properties
[ActiveHeadset]: #ActiveHeadset
[ActiveHeadsetCamera]: #ActiveHeadsetCamera
[ActiveHeadsetVelocity]: #ActiveHeadsetVelocity
[ActiveLeftController]: #ActiveLeftController
[ActiveLeftControllerVelocity]: #ActiveLeftControllerVelocity
[ActiveLeftHapticProcess]: #ActiveLeftHapticProcess
[ActiveLinkedAliasAssociation]: #ActiveLinkedAliasAssociation
[ActivePlayArea]: #ActivePlayArea
[ActiveRightController]: #ActiveRightController
[ActiveRightControllerVelocity]: #ActiveRightControllerVelocity
[ActiveRightHapticProcess]: #ActiveRightHapticProcess
[CameraRigs]: #CameraRigs
[Configuration]: #Configuration
[HeadsetAlias]: #HeadsetAlias
[HeadsetCameras]: #HeadsetCameras
[HeadsetOriginAlias]: #HeadsetOriginAlias
[Headsets]: #Headsets
[HeadsetSupplementCameras]: #HeadsetSupplementCameras
[HeadsetVelocityTrackers]: #HeadsetVelocityTrackers
[LeftControllerAlias]: #LeftControllerAlias
[LeftControllerHapticProcesses]: #LeftControllerHapticProcesses
[LeftControllers]: #LeftControllers
[LeftControllerVelocityTrackers]: #LeftControllerVelocityTrackers
[PlayAreaAlias]: #PlayAreaAlias
[PlayAreas]: #PlayAreas
[RightControllerAlias]: #RightControllerAlias
[RightControllerHapticProcesses]: #RightControllerHapticProcesses
[RightControllers]: #RightControllers
[RightControllerVelocityTrackers]: #RightControllerVelocityTrackers
[Methods]: #Methods
[GetFirstActiveCamera(IEnumerable<Camera>)]: #GetFirstActiveCameraIEnumerable<Camera>
[GetFirstActiveGameObject(IEnumerable<GameObject>)]: #GetFirstActiveGameObjectIEnumerable<GameObject>
[GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)]: #GetFirstActiveHapticProcessIEnumerable<HapticProcess>
[GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)]: #GetFirstActiveLinkedAliasAssociationCollectionIEnumerable<LinkedAliasAssociationCollection>
[GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)]: #GetFirstActiveVelocityTrackerIEnumerable<VelocityTracker>
[OnAfterCameraRigsChange()]: #OnAfterCameraRigsChange
[OnBeforeCameraRigsChange()]: #OnBeforeCameraRigsChange
[OnCameraRigAdded(LinkedAliasAssociationCollection)]: #OnCameraRigAddedLinkedAliasAssociationCollection
[OnCameraRigRemoved(LinkedAliasAssociationCollection)]: #OnCameraRigRemovedLinkedAliasAssociationCollection
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RefreshCameraRigsConfiguration()]: #RefreshCameraRigsConfiguration
[SubscribeToCameraRigsEvents()]: #SubscribeToCameraRigsEvents
[UnsubscribeFromCameraRigsEvents()]: #UnsubscribeFromCameraRigsEvents
