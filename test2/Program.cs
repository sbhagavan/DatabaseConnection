//using Castle.MicroKernel;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test2.DatabaseImplementors;

//Test
namespace test2
{
    class Program
    {

        public void Ninjectload()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IActivityDataHandler>().To<SqlServerActivityData>();
            kernel.Bind<ILikeDataHandler>().To<SqlServerLikeData>();
            kernel.Bind<IUserDataHandler>().To<SqlLiteUserData>();
            kernel.Bind<ICommentDataHandler>().To<SqlServerCommentData>();
            var test = kernel.Get<CRUDTester>();
            var rows = test.GetComment(3);
            foreach (var row in rows)
                Console.WriteLine(row.CommentText);

            var likes = test.GetLike(406508);
            if (likes != null)
                Console.WriteLine("Number of likes = {0}", likes.Count);

            var activities = test.GetActivitiesByPortal(146);
            Console.WriteLine("Number of activities = {0}", activities.Count);

            Console.ReadLine();
        }

        public void CastleLoad()
        {
            //Dependency injection using Castle Windsor project

            //IKernel kernel = new DefaultKernel();
            //kernel.AddComponent("SqlLiteActivityData", typeof(IActivityDataHandler), typeof(SqlLiteActivityData));
            //kernel.AddComponent("SqlLiteCommentData", typeof(ICommentDataHandler), typeof(SqlLiteCommentData));
            //kernel.AddComponent("SqlLiteLikeData", typeof(ILikeDataHandler), typeof(SqlLiteLikeData));
            //kernel.AddComponent("SqlLiteUserData", typeof(IUserDataHandler), typeof(SqlLiteUserData));

            //CRUDTester test = (CRUDTester)kernel[typeof(CRUDTester)];
            //test.CreateAllTables();

            //kernel.ReleaseComponent(test);
        }
        public static void Main(string[] args)
        {
            //Dependency injection by hand

            //IActivityDataHandler ia = new SqlLiteActivityData();
            //ICommentDataHandler ic = new SqlLiteCommentData();
            //ILikeDataHandler il = new SqlLiteLikeData();
            //IUserDataHandler iu = new SqlLiteUserData();

            //CRUDTester test = new CRUDTester(ia, il, iu, ic);
            //test.CreateAllTables();
            //Console.WriteLine("Success!");
            //Console.ReadLine();

            new Program().Ninjectload();

           
        }
    }

}
