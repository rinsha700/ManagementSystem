namespace ManagementSystem.Utils
{
    public class Helper
    {
        public void FileWrite(string name,string subject,string email)
        {


            StreamWriter st = new StreamWriter(@"C:\Users\SH-PKD-007\source\repos\ManagementSystem\staicFiles\" + name+ ".txt");
            st.WriteLine("Employe Name:" + name);
            st.WriteLine("Employe Subject:" + subject);
            st.WriteLine("Employe Salary:" + email);
         
            st.Close();
        }

    }
}
