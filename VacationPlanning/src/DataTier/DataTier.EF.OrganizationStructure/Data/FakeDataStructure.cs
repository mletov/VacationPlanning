using ApplicationTier.Domain.Entities;


namespace DataTier.EF.OrganizationStructure.Data
{

    public static class FakeDataStructure
    {
        public static IEnumerable<OrgStructure> OrgStructures => new List<OrgStructure>()
        {
            new OrgStructure()
            {
                Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                PositionName = "Руководитель",
                //ParentId = null,
                IsFolder = 1

            },
            new OrgStructure()
            {
                Id = Guid.Parse("63729686-a368-4eeb-8bfa-cc69b6050d02"),
                PositionName = "Начальник IT",
                ParentId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                IsFolder = 1
            },
            new OrgStructure()
            {
                Id = Guid.Parse("68729686-a368-4eeb-8bfa-cc69b6050d02"),
                PositionName = "Программист",
                ParentId = Guid.Parse("63729686-a368-4eeb-8bfa-cc69b6050d02"),
                IsFolder = 2
            },            
            new OrgStructure()
            {
                Id = Guid.Parse("73729686-a368-4eeb-8bfa-cc69b6050d02"),
                PositionName = "Начальник ChR",
                ParentId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                IsFolder = 1
            },
            new OrgStructure()
            {
                Id = Guid.Parse("73739686-a368-4eeb-8bfa-cc69b6050d02"),
                PositionName = "Сотрудник ChR",
                ParentId = Guid.Parse("73729686-a368-4eeb-8bfa-cc69b6050d02"),
                IsFolder = 2
            }
            
        };

    }
}

