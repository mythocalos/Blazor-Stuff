    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        [NotMapped]
        public int ProductID { get; set; }
        [NotMapped]
        public int SubCategoryID { get; set; }
    }

        public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string SubCategoryName { get; set; }
    }

        public class MainProduct
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
    }
