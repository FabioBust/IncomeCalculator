namespace IncomeCalculator
{
    public class CategoryManager
    {
        public CategoryManager()
        {
            Categories = new List<Category>();
        }
        public Category AddCategory(string name, decimal amount, AmountType type)
        {
            Category newCategory = new Category
            {
                Name = name,
                Amount = amount,
                Type = type
            };

            return newCategory;
        }

        public void RemoveCategory(Category category)
        {
            
        }

        Category UpdateCategory(Category category, string newName, decimal newAmount, AmountType newType)
        {
            category.Name = newName;
            category.Amount = newAmount;
            category.Type = newType;

            return category;
        }
    }
}