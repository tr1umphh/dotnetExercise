using System.Collections;

namespace Exercise;

public class Category
{
    private int id { get; set; }
    private string catergoryName { get; set; }

    public Category(string catergoryName)
    {
        this.id = id;
        this.catergoryName = catergoryName;
    }

    public override string ToString()
    {
        return $"{catergoryName}";
    }

}