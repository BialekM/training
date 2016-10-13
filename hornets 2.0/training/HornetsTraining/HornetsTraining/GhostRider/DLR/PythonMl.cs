using LinkedIn.NET;
using LinkedIn.NET.Members;
using LinkedIn.NET.Options;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace Toci.HornetsTraining.GhostRider.DLR
{
    public class PythonMl
    {
        public void Test()
        {
            //LinkedIn.NET.LinkedInClient person = new LinkedInClient("", "");
            //var response = person.GetMember(new LinkedInGetMemberOptions {});
            //response.Result.FullProfile.Connections.

            System.IO.Directory.SetCurrentDirectory("../../../HornetsTraining/GhostRider/DLR/Lib");
            ScriptRuntime py = Python.CreateRuntime();

            dynamic neuralNetwork = py.UseFile("../NeuralNetwork.py");

            int[][] array = new int[4][]; //{new[][] {0, 0, 1}, new[] {1, 1, 1}, new[] {1, 0, 1}, new[] {0, 1, 1}};
            int[] output = new[] {0, 1, 1, 0};
            for (int i = 0; i < 4; i++)
            {
                array[i] = new int[3];
            }

            array[0][0] = 0; array[0][1] = 0; array[0][2] = 1;
            array[1][0] = 1; array[1][1] = 1; array[1][2] = 1;
            array[2][0] = 1; array[2][1] = 0; array[2][2] = 1;
            array[3][0] = 0; array[3][1] = 1; array[3][2] = 1;

            neuralNetwork.train(array, output, 10000);
        }
    }
}