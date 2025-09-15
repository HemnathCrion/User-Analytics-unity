using Unity.PlasticSCM.Editor.UI;
using UnityEngine;
using UnityEngine.UnityConsent;
public class ModernAnalyticsConsent : MonoBehaviour
{
   public void GrantAnalyticsConsent()
   {
      ConsentState consent = EndUserConsent.GetConsentState();

      consent.AnalyticsIntent = ConsentStatus.Granted;

      EndUserConsent.SetConsentState(consent);

      Debug.Log("Analytics consent granted. Analytics will now collect data.");
   }

   // Optional: revoke later if needed
      // public void RevokeAnalytics()
      // {
      //    var consent = EndUserConsent.GetConsentState();
      //    consent.AnalyticsIntent = ConsentStatus.Denied;
      //    EndUserConsent.SetConsentState(consent);
      //
      //    Debug.Log("Analytics consent revoked.");
      // }
   
}
