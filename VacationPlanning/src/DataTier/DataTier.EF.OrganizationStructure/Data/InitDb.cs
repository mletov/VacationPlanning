namespace DataTier.EF.OrganizationStructure.Data;

public class InitDb: IDbInit
{
    private readonly DataContextStruct _dataContext;

    public InitDb(DataContextStruct dataContext)
    {
        _dataContext = dataContext;
    }


    public  void InitializeDb()
        {

            //добавление начальных данных по оргструктуре
        _dataContext.AddRange(FakeDataStructure.OrgStructures);
        _dataContext.SaveChanges();
         /*
            _dataContext.AddRange(FakeDataFactory.Employees);
            _dataContext.SaveChanges();

            _dataContext.AddRange(FakeDataFactory.Preferences);
            _dataContext.SaveChanges();

            _dataContext.AddRange(FakeDataFactory.Customers);
            _dataContext.SaveChanges();   
        */


        }
            
    
}