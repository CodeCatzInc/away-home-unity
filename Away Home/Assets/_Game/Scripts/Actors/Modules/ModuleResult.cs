﻿
/// <summary>
/// The result of trying to perform an action with a Module.
/// </summary>
public enum ModuleResult {
	Success,
	AlreadyActive,
	AlreadyInactive,
	AlreadyEnabled,
	AlreadyDisabled,

    InCooldownState,

	InvalidAsset,
	InvalidSystem,
	InvalidHardpoint,

	InsufficientCpu,
	InsufficientPower,

	IncompatibleSocket,
	HardpointNotEmpty,

	NoModule,
    NotImplemented
}