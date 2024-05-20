using System.ComponentModel.DataAnnotations.Schema;

namespace MMO_EFCore
{

    [Table("Item")]
    public class Item
    {
        // Id -> PK
        public int ItemId { get; set; }
        public string TemplateId { get; set; }
        public DateTime CreateDate { get; set; }

        // 다른 클래스 참조 -> FK
        public int OwnerId { get; set; }
        public Player Owner { get; set; }


    }


    // Class = 테이블 이름
    public class Player
    {
        // Id -> PK
        public int PlayerId { get; set; }
        public string Name { get; set; }


    }

}
