using System.Xml.Serialization;

namespace Library;

public class Visitor
{
    public int AgeSum(Node<Person> node)
    {
        int result = 0;
        
        result += node.Element.Age;

        foreach (var child in node.Children)
        {
            result += AgeSum(child);
        }
        
        return result; 
    }

    public int EldestChild(Node<Person> node)
    {
        int result = 0;

        if (node.Children.Count == 0)
        {
            return node.Element.Age;
        }
        
        foreach (var child in node.Children)
        {
            int eldestChild = EldestChild(child);
            
            if (eldestChild > result)
            {
                result = eldestChild;
            }
        }
        
        return result; 
    }
    
    public string LongestName(Node<Person> node)
    {
        string result = node.Element.Name;
        
        foreach (var child in node.Children)
        {
            string longestName = LongestName(child);
            
            if (longestName.Length > result.Length)
            {
                result = longestName;
            }
        }
        
        return result; 
    }
}