using Sitecore.EmailCampaign.Cm.Dispatch;
using Sitecore.EmailCampaign.Cm.Pipelines.SendEmail;
using Sitecore.Modules.EmailCampaign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.EmailCampaign.Cm.Pipelines.SendEmail
{
  public class ReleaseGenerationSemaphore
  {
    public void Process(SendMessageArgs args)
    {
      if(args.Task is TestMessageTask)
      {
        EcmGlobals.GenerationSemaphore.ReleaseOne();
      }
    }
  }
}