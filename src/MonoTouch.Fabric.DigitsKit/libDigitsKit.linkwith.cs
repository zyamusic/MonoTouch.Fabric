using System;
using ObjCRuntime;

[assembly: LinkWith ("libDigitsKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, Frameworks = "Security SystemConfiguration CFNetwork AddressBook", LinkerFlags = "-lstdc++ -lz", SmartLink = true, ForceLoad = true)]
