using System;
using ObjCRuntime;

[assembly: LinkWith ("libTwitterCore.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, Frameworks = "Security SystemConfiguration CFNetwork CoreData Accounts Social", LinkerFlags = "-lstdc++ -lz", SmartLink = true, ForceLoad = true)]
