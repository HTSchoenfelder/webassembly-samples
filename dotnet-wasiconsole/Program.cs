using System;
using System.Runtime.InteropServices;

Console.WriteLine($"Hello {RuntimeInformation.OSDescription}:{RuntimeInformation.OSArchitecture}");
Console.WriteLine($"With love from {RuntimeInformation.FrameworkDescription}");