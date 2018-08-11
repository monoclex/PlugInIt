﻿using PlugInIt;
using System;

namespace TestProject.Core {
	public interface ITestProjectPlugin : IManagedPlugin {
		string Author { get; }
		string Version { get; }
		Guid Id { get; }

		void Start();
		void Stop();
	}
}
