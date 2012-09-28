using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.CodeDom;
using System.ComponentModel;

/// <summary>
/// Summary description for RandomNumberExpressionBuilder
/// </summary>
public class RandomNumberExpressionBuilder : ExpressionBuilder
{
	public RandomNumberExpressionBuilder()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string GetRandomNumber(int lowerLimit, int upperLimit)
    {
        Random random = new Random();
        int randomValue = random.Next(lowerLimit, upperLimit);
        return randomValue.ToString();
    }

    public override CodeExpression GetCodeExpression(System.Web.UI.BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context)
    {
        if (!entry.Expression.Contains(","))
        {
            throw new ArgumentException(
            "Must include two numbers separated by a comma.");
        }
        else
        {
            // Get the two numbers.
            string[] numbers = entry.Expression.Split(',');
            if (numbers.Length != 2)
            {
                throw new ArgumentException("Only include two numbers.");
            }
            else
            {
                int lowerLimit, upperLimit;
                if (Int32.TryParse(numbers[0], out lowerLimit) &&
                Int32.TryParse(numbers[1], out upperLimit))
                {
                    // Get a reference to the class that has the
                    // GetRandomNumber() method.
                    // (It's the class where this code is executing.)
                    CodeTypeReferenceExpression typeRef = new
                    CodeTypeReferenceExpression(this.GetType());
                    CodeExpression[] methodParameters = new CodeExpression[2];
                    methodParameters[0] = new CodePrimitiveExpression(lowerLimit);
                    methodParameters[1] = new CodePrimitiveExpression(upperLimit);
                    return new CodeMethodInvokeExpression(typeRef, "GetRandomNumber", methodParameters);
                }
                else
                {
                    throw new ArgumentException("Use valid integers.");
                }
            }
        }
    }
}