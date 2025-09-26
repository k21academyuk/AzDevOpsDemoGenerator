﻿namespace RestAPI.Viewmodel.Plans
{
    public class DeliveryPlans
    {
        public class GetPlans
        {
            public class Root
            {
                public int count { get; set; }
                public List<Value> value { get; set; }
            }

            public class Value
            {
                public string id { get; set; }
                public int revision { get; set; }
                public string name { get; set; }
                public string type { get; set; }
            }
        }
    }
}
