using System;
using System.Threading.Tasks;

namespace SeeSharpBasics.training7.tpl
{
    public abstract class Homework
    {
        //plik
        // do 100 wczytujecie dcaly plik i jedziecie as paralel
        //powyzej

        public abstract void SequentialFileProcessing(int threads);

        protected virtual Task GetThread(Action action)
        {
            TaskFactory tf = new TaskFactory();

            return tf.StartNew(action);
        }

        protected virtual void Measure(string text)
        {
            //return text.Length;

        }
    }
}