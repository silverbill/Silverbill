using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("/api/merch")]
public class MerchController : CRUDController<Merch> {
    public MerchController(IRepository<Merch> r) : base(r){}
}

[Route("/api/merchlist")]
public class MerchListController : CRUDController<MerchList> {
    public MerchListController(IRepository<MerchList> r) : base(r){}
}

[Route("/api/bizCat")]
public class bizCatController : CRUDController<bizCat> {
    public bizCatController(IRepository<bizCat> r) : base(r){}
}