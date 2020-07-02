# Class TrackedAliasConfigurator

Sets up the Tracked Alias Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Facade]
  * [Headset]
  * [HeadsetOrigin]
  * [HeadsetVelocityTrackers]
  * [IncludeHeadsetSupplementCameras]
  * [LeftController]
  * [LeftControllerVelocityTrackers]
  * [PlayArea]
  * [RightController]
  * [RightControllerVelocityTrackers]
  * [ValidCameras]
* [Methods]
  * [NotifyHeadsetTrackingBegun()]
  * [NotifyLeftControllerTrackingBegun()]
  * [NotifyRightControllerTrackingBegun()]
  * [NotifyTrackedAliasChanged(GameObject)]
  * [OnEnable()]
  * [SetUpCameraRigsConfiguration()]

## Details

##### Inheritance

* System.Object
* TrackedAliasConfigurator

##### Namespace

* [Tilia.CameraRigs.TrackedAlias]

##### Syntax

```
public class TrackedAliasConfigurator : MonoBehaviour
```

### Properties

#### Facade

The public facade.

##### Declaration

```
public TrackedAliasFacade Facade { get; protected set; }
```

#### Headset

The ObjectFollower component for the Headset.

##### Declaration

```
public ObjectFollower Headset { get; protected set; }
```

#### HeadsetOrigin

The ObjectFollower component for the HeadsetOrigin within the PlayArea Alias.

##### Declaration

```
public ObjectFollower HeadsetOrigin { get; protected set; }
```

#### HeadsetVelocityTrackers

The VelocityTrackerProcessor component containing the Headset Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor HeadsetVelocityTrackers { get; protected set; }
```

#### IncludeHeadsetSupplementCameras

Determines whether to include the CameraRig HeadsetSupplementCameras in the [ValidCameras] collection.

##### Declaration

```
public bool IncludeHeadsetSupplementCameras { get; set; }
```

#### LeftController

The ObjectFollower component for the Left Controller.

##### Declaration

```
public ObjectFollower LeftController { get; protected set; }
```

#### LeftControllerVelocityTrackers

The VelocityTrackerProcessor component containing the Left Controller Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor LeftControllerVelocityTrackers { get; protected set; }
```

#### PlayArea

The ObjectFollower component for the PlayArea.

##### Declaration

```
public ObjectFollower PlayArea { get; protected set; }
```

#### RightController

The ObjectFollower component for the Right Controller.

##### Declaration

```
public ObjectFollower RightController { get; protected set; }
```

#### RightControllerVelocityTrackers

The VelocityTrackerProcessor component containing the Right Controller Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor RightControllerVelocityTrackers { get; protected set; }
```

#### ValidCameras

The ListContainsRule for defining the valid Camera collection.

##### Declaration

```
public ListContainsRule ValidCameras { get; protected set; }
```

### Methods

#### NotifyHeadsetTrackingBegun()

Notifies that the headset has started being tracked.

##### Declaration

```
public virtual void NotifyHeadsetTrackingBegun()
```

#### NotifyLeftControllerTrackingBegun()

Notifies that the left controller has started being tracked.

##### Declaration

```
public virtual void NotifyLeftControllerTrackingBegun()
```

#### NotifyRightControllerTrackingBegun()

Notifies that the right controller has started being tracked.

##### Declaration

```
public virtual void NotifyRightControllerTrackingBegun()
```

#### NotifyTrackedAliasChanged(GameObject)

Notifies when the tracked alias source has changed.

##### Declaration

```
public virtual void NotifyTrackedAliasChanged(GameObject newAlias)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | newAlias | n/a |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### SetUpCameraRigsConfiguration()

Sets up the TrackedAlias prefab with the specified settings.

##### Declaration

```
public virtual void SetUpCameraRigsConfiguration()
```

[Tilia.CameraRigs.TrackedAlias]: README.md
[TrackedAliasFacade]: TrackedAliasFacade.md
[ValidCameras]: TrackedAliasConfigurator.md#ValidCameras
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Facade]: #Facade
[Headset]: #Headset
[HeadsetOrigin]: #HeadsetOrigin
[HeadsetVelocityTrackers]: #HeadsetVelocityTrackers
[IncludeHeadsetSupplementCameras]: #IncludeHeadsetSupplementCameras
[LeftController]: #LeftController
[LeftControllerVelocityTrackers]: #LeftControllerVelocityTrackers
[PlayArea]: #PlayArea
[RightController]: #RightController
[RightControllerVelocityTrackers]: #RightControllerVelocityTrackers
[ValidCameras]: #ValidCameras
[Methods]: #Methods
[NotifyHeadsetTrackingBegun()]: #NotifyHeadsetTrackingBegun
[NotifyLeftControllerTrackingBegun()]: #NotifyLeftControllerTrackingBegun
[NotifyRightControllerTrackingBegun()]: #NotifyRightControllerTrackingBegun
[NotifyTrackedAliasChanged(GameObject)]: #NotifyTrackedAliasChangedGameObject
[OnEnable()]: #OnEnable
[SetUpCameraRigsConfiguration()]: #SetUpCameraRigsConfiguration
