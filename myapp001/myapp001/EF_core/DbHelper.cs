using Microsoft.EntityFrameworkCore;
using myapp001.models;

namespace myapp001.EF_core
{
    public class DbHelper
    {
        private EF_Datacontext _context;

        public DbHelper(EF_Datacontext context) {  
            _context = context; 
        }

        public List<Student_model> Getall()
        {
            List<Student_model> res= new List<Student_model>();
            var data=_context.students.ToList();
            data.ForEach(x => res.Add(new Student_model()
            {
                id=x.id, name=x.name,
                address=x.address,


            }));
            return res;

        }


        public Student_model GetById(int id)
        {
            Student_model res= new Student_model();
            var row = _context.students.Where(d => d.id.Equals(id)).FirstOrDefault();
            if (row != null) {
                return new Student_model()
                {
                    id = row.id,
                    name = row.name,
                    address = row.address,

                };
            }
            return null;
              
        }

        public void NewStu(Student_model model)
        {
            Student DbTable=new Student();

            if (model.id > 0)
            {
                DbTable = new Student
                {
                    id = model.id,
                    name = model.name,
                    address = model.address,
                };
                _context.Add(DbTable);

            }
            _context.SaveChanges();


        }
        public void UpdStu(int id, Student_model model)
        {
            Student DbTable=new Student();
            if(model.id > 0)
            {
                DbTable=_context.students.Where(d=> d.id.Equals(id)).FirstOrDefault();
            if(DbTable != null)
                {
                    DbTable.address = model.address;
                    DbTable.name = model.name;
                }
            _context.SaveChanges();
            }

        }

        public void DelStu(int id)
        {
           var res= _context.students.Where(d => d.id.Equals(id)).FirstOrDefault();
            if (res != null)
            {
                _context.students.Remove(res);
            }
            _context.SaveChanges() ;    



        }
    }
}
