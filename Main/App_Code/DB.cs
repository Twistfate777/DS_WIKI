using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// DB 的摘要说明
/// </summary>
public class DB
{
    public static DataClassesDataContext db;
    public DB()
    {
        db = new DataClassesDataContext();
    }

    public bool CheckUserExist(string user)
    {
        var result = from r in db.Table where r.user.Equals(user) select r;
        return result.Any();
    }

    public bool CheckLogin(string user,string passwd)
    {
        var result = from r in db.Table where r.user.Equals(user) && r.passwd.Equals(passwd) select r;
        return result.Any();
    }

    public void InsertTable(string user,string passwd,string name)
    {
        Table table = new Table();
        table.user = user;
        table.passwd = passwd;
        table.name = name;
        db.Table.InsertOnSubmit(table);
        db.SubmitChanges();
    }
}