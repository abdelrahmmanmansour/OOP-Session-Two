using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_Two.Task_two
{
    public class Parent_Test
    {
        // Automatic Property:
        public string Public { get; set; }
        private string Private { get; set; }
        private protected string Private_Protected { get; set; }
        protected internal string Protected_Internal { get; set; }
        protected string Protected { get; set; }
        internal string Internal { get; set; }

        // Method:
        public void Print()
        {
            Console.WriteLine($"Public: {Public} , Private: {Private} , Private_Protected: {Private_Protected} , Protected_Internal: {Protected_Internal} , Protected: {Protected} , Internal: {Internal}");
        }
    }

    public class Child_Test : Parent_Test
    {
        public void Print()
        {
            // Private: {Private}: Not Accessible (inside class only)
            Console.WriteLine($"Public: {Public} , Private_Protected: {Private_Protected} , Protected_Internal: {Protected_Internal} , Protected: {Protected} , Internal: {Internal}");
        }
    }
}
