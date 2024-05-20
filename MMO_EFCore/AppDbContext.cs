using Microsoft.EntityFrameworkCore;

namespace MMO_EFCore
{
    public class AppDbContext : DbContext
    {
        // Dbset<T> class를 참고하여 db에서 테이블 생성
        // 모델링을 분석해서 칼럼을 찾는다
        // 모델링 class 에서 참조하는 다른 class 가 있으면 그 class 도 분석
        // OnModelCreating 함수 호출

        // DbSet<Item> -> EFCore에 알려준다
        // Item 이라는 DB 테이블이 있는데 세부적인 내용은 Item 클래스 참조 
        public  DbSet<Item> Items { get; set; }

        // DB ConnectionString
        // 어떤 DB를 어떻게 연결해라
        public const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EfCoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
        }

    }
}
