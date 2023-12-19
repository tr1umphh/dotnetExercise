using System.Collections;

namespace Exercise;

public class Category
{
    public int id { get; set; }
    public string catergoryName { get; set; }

    public Category(int id, string catergoryName)
    {
        this.id = id;
        this.catergoryName = catergoryName;
    }
}