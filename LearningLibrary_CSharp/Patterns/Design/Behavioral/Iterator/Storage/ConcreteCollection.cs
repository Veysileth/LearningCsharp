using System.Collections.Generic;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Iterator
{
    internal class ConcreteCollection : AbstractCollection
    {
        private List<Storage.Employee> listEmployees = new();

        //Create Iterator
        public Storage.Iterator CreateIterator()
        {
            return new Storage.Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }

        //Add items to the collection
        public void AddEmployee(Storage.Employee employee)
        {
            listEmployees.Add(employee);
        }

        //Get item from collection
        public Storage.Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}