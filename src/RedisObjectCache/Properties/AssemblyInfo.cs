﻿//
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("RedisObjectCacheProvider")]
[assembly: AssemblyCopyright("Copyright © 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyMetadata("Serviceable", "True")]

#if !CODESIGNING
[assembly: InternalsVisibleTo("Microsoft.Web.RedisObjectCacheProvider.Unit.Tests_net462")]
[assembly: InternalsVisibleTo("Microsoft.Web.RedisObjectCache.Functional.Tests_net462")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
#if !NOCOMMONASSEMBLYVERSION
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]
#endif
[assembly: AssemblyTitle("Cache Providers")]