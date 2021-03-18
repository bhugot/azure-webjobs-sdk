﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.Azure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Azure.WebJobs.StorageProvider.Blobs
{
    /// <summary>
    /// Extension methods for Storage Blobs integration.
    /// </summary>
    public static class AzureBlobBuilderExtensions
    {
        /// <summary>
        /// Adds the Storage Blobs extension to the provided <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to configure.</param>
        public static void AddAzureStorageBlobs(this IServiceCollection services)
        {
            services.AddAzureClientsCore();
            services.TryAddSingleton<BlobServiceClientProvider>();
        }
    }
}