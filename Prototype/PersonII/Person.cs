namespace Prototype.PersonII
{
    public class Person
    {
        public int Age;
        public DateTime Birthday;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowPerson() => (Person)MemberwiseClone();

        [Obsolete]
        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
    }
}
