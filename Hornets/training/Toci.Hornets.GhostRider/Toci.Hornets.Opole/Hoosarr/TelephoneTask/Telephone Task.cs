﻿using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Opole.Hoosarr.TelephoneTask
{
    public class TelephoneTask : TelephoneInterpreter
 {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1:

                    return new PhotoCommunication();

                case 2:

                    return new SmsCommunication();

                case 3:

                    return new VoiceCommunication();

                default:
                    return null;
            }
        }

        protected override string MyNick()
        {
            return "Hoosarr";
        }
    }
}