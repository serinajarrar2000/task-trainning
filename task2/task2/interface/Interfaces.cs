namespace WebApplication62.internalinterface
{
    public interface Interfaces
{
        void Getstudent();
        void Getstudents(int id);
        void Addstudent(student request);
        void updatestudent(student requestt);
        void Deletestudent(int id);
        }

    public class student : Interfaces
    {
        public void Addstudent(student request)
        {
            throw new NotImplementedException();
        }

        public void Deletestudent(int id)
        {
            throw new NotImplementedException();
        }

        public void Getstudent()
        {
            throw new NotImplementedException();
        }
        public void Getstudents(int id)
        {
            throw new NotImplementedException();
        }
        public void updatestudent(student requestt)
        {
            throw new NotImplementedException();
        }
    }
}
