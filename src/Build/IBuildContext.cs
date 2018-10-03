﻿using System;
using System.Reflection;
using Unity.Builder;
using Unity.Policy;
using Unity.Storage;

namespace Unity.Build
{
    public interface IBuildContext : INamedType, IPolicyList
    {
        /// <summary>Reference to container.</summary>
        /// <remarks>Reference to the container used to execute this build. </remarks>
        /// <returns> Interface for the hosting container</returns>
        IUnityContainer Container { get; }

        /// <summary>
        /// Resolve type/object/dependency using current context
        /// </summary>
        /// <param name="type">Type of requested object</param>
        /// <param name="name">Name of registration</param>
        /// <returns></returns>
        object Resolve(Type type, string name);

        object Resolve(PropertyInfo property, string name, IResolverPolicy resolver = null);

        object Resolve(ParameterInfo parameter, string name, IResolverPolicy resolver = null);
    }
}