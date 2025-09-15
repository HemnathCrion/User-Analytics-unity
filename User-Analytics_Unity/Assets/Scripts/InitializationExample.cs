using System;
using Unity.Services.Core;
using Unity.Services.Analytics;
using UnityEngine;

public class InitializationExample : ModernAnalyticsConsent
{
	async void Awake()
	{
		try
		{
			await UnityServices.InitializeAsync();
		}
		catch (Exception e)
		{
			Debug.LogException(e);
		}
		GrantAnalyticsConsent();
		// RevokeAnalytics();
	}
}