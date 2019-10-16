﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using Refit;
using server.Models;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace server.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace server.Services
{
    using server.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIAccountService : IAccountService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIAccountService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<Account> IAccountService.GetBase(string accountId, string authorization)
        {
            var arguments = new object[] { accountId, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetBase", new Type[] { typeof(string), typeof(string) });
            return (Task<Account>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Image[]> IAccountService.GetImages(string username, int page, string authorization)
        {
            var arguments = new object[] { username, page, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetImages", new Type[] { typeof(string), typeof(int), typeof(string) });
            return (Task<Image[]>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<BlockedUser> IAccountService.GetSettings(string username, string authorization)
        {
            var arguments = new object[] { username, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetSettings", new Type[] { typeof(string), typeof(string) });
            return (Task<BlockedUser>)func(Client, arguments);
        }
    }
}

namespace server.Services
{
    using server.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIImageService : IImageService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIImageService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<Image> IImageService.GetById(string imageHash, string authorization)
        {
            var arguments = new object[] { imageHash, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetById", new Type[] { typeof(string), typeof(string) });
            return (Task<Image>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Basic> IImageService.Delete(string imageHash, string authorization)
        {
            var arguments = new object[] { imageHash, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("Delete", new Type[] { typeof(string), typeof(string) });
            return (Task<Basic>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Basic> IImageService.SetFavorite(string imageHash, string authorization)
        {
            var arguments = new object[] { imageHash, authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("SetFavorite", new Type[] { typeof(string), typeof(string) });
            return (Task<Basic>)func(Client, arguments);
        }
    }
}