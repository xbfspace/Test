

--业务模块
create table business_module(
     id int,
	 code nvarchar(200),--模块编码
	 name nvarchar(200),--模块名称
	 desc nvarchar(200)--模块描述
)
go
--权限表
create table right(
    id int,
	code int,--权限编码
	name nvarchar(200) ,--权限名称
	desc nvarchar(200) ,--权限描述
	businessModule int --所属业务模块id
)
go
--权限分配表
create table right_assign(
    id int,
	businessModule int,--权限业务模块编码
	right int,--权限项编码
	subject int,--权限所有者对象id
	subjectType int,--权限所有者类别
	grantType int--授权类型： 0：拒绝 1：允许
)