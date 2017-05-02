using System;


namespace _10.FirmRecord
{
    public class FirmRecord
    {
        private String firstName;
        private String familyName;
        private byte age;
        private char gender;
        private  ushort IDNumber;
        private uint uniqueNumber;
        

            public string getName()
                {
                    return this.firstName; 
                }
            public void setName(String firstName)
                {
                    this.firstName = firstName; 
                }

            public string getFamilyName()
                {
                return this.familyName;
                }
            public void setFamilyName(String familyName)
                {
                this.familyName = familyName;
                }

            public byte getAge()
                {
                return this.age;
                }
            public void setAge(byte age)
                {
                this.age = age;
                }

            public char getGender()
                {
                return this.gender;
                }
            public void setGender(char gender)
                {
                this.gender = gender;
                }

            public ushort getIDNumber()
                {
                return this.IDNumber;
                }
            public void setIDNumber(ushort IDNumber)
                {
                this.IDNumber = IDNumber;
                }

            public uint getUniqueNumber()
                {
                return this.uniqueNumber;
                }
            public void setUniqueNumber(uint uniqueNumber)
                {
                this.uniqueNumber = uniqueNumber;
                }

         static void Main(string[] args)
         {
            FirmRecord Employee1 = new FirmRecord();
            FirmRecord Employee2 = new FirmRecord();
            FirmRecord Employee3 = new FirmRecord();
            Employee1.setAge(34);
            Employee2.setGender('M');
            Employee3.setIDNumber(10045);
            Console.WriteLine(Employee1.getAge());
            Console.WriteLine(Employee2.getGender());
            Console.WriteLine(Employee3.getIDNumber());
         }
    }
}
    

