﻿using System;
using Kentico.Kontent.Delivery.Abstractions.RetryPolicy;
using Kentico.Kontent.Delivery.Configuration;
using Kentico.Kontent.Delivery.Configuration.DeliveryOptions;
using Microsoft.Extensions.Options;

namespace Kentico.Kontent.Delivery.RetryPolicy
{
    internal class DefaultRetryPolicyProvider : IRetryPolicyProvider
    {
        private readonly DefaultRetryPolicyOptions _retryPolicyOptions;

        public DefaultRetryPolicyProvider(IOptions<DeliveryOptions> options)
        {
            _retryPolicyOptions = options.Value.DefaultRetryPolicyOptions ?? throw new ArgumentNullException(nameof(options));
        }

        public IRetryPolicy GetRetryPolicy() => new DefaultRetryPolicy(_retryPolicyOptions);
    }
}