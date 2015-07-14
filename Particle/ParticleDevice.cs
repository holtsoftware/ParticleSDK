﻿/*
Copyright 2015 Sannel Software, L.L.C.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
	public class ParticleDevice
	{
		public String Id { get; internal set; }
		public String Name { get; internal set; }
		public String LastApp { get; internal set; }
		public String LastIPAddress { get; internal set; }
		public DateTime LastHeard { get; internal set; }
		public ParticleDeviceType DeviceType { get; internal set; }
		public bool IsConnected { get; internal set; }

		internal ParticleDevice(JObject obj)
		{
			ParseObject(obj);
		}

		internal void ParseObject(JObject obj)
		{

		}

		private Dictionary<String, String> variables = new Dictionary<string, string>();
		public IReadOnlyDictionary<String, String> Variables
		{
			get
			{
				return variables;
			}
		}

		private List<String> functions = new List<string>();
		public IReadOnlyList<String> Functions
		{
			get
			{
				return functions;
			}
		}

		public async Task<T> GetVariableValueAsync<T>(String variableName)
		{
			throw new NotImplementedException();
		}

		public async Task<int> CallFunctionAsync(String functionName, params String[] args)
		{
			throw new NotImplementedException();
		}

		public async Task<Result> RefreshAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Result> UnclaimAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Result> RenameAsync()
		{
			throw new NotImplementedException();
		}

		// this method signature should probably change
		public async Task<Result> FlashFilesAsync(IDictionary<String, byte[]> files)
		{
			throw new NotImplementedException();
		}

		// this method signature should probably change
		public async Task<Result> FlashKnownAppAsync(String appName)
		{
			throw new NotImplementedException();
		}

		// this method signature should probably change
		public async Task<Result> CompileAndFlashFiles(IDictionary<String, byte[]> files)
		{
			throw new NotImplementedException();
		}

		// this method signature should probably change and its return type will change
		public async Task<Result> ComplileFilesAsync(IDictionary<String, byte[]> files)
		{
			throw new NotImplementedException();
		}

		/*id: "390032000647343232363230"
name: "Proto"
last_app: null
last_ip_address: "174.52.197.239"
last_heard: "2015-07-11T05:25:09.960Z"
product_id: 6
connected: true*/

		/*
id: "390032000647343232363230"
name: "Proto"
connected: true
variables: {
temp: "double"
}-
functions: [1]
0:  "led"
-
cc3000_patch_version: null
product_id: 6
last_heard: "2015-07-11T05:32:56.614Z"*/
	}
}
