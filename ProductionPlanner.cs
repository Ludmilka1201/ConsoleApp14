namespace ConsoleApp14;

public class ProductionPlanner
{
     public ProductionPlan PlanOrder(Order order)
    {
        ProductionPlan plan = new ProductionPlan();
        plan.Order = order;
        plan.Details = new List<Detail>();
        plan.Materials = new List<Material>();

        foreach (var detail in order.Details)
        {
            plan.Details.Add(detail);
            foreach (var material in detail.Materials)
            {
                plan.Materials.Add(material);
            }
        }

        foreach (var detail in plan.Details)
        {
            foreach (var step in detail.ProductionSteps)
            {
                plan.TotalTime += step.Time;
            }
        }

        return plan;
    }
}