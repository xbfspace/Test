

--业务模块模板定义表
create table business_module_template(
     id int,
	 code nvarchar(200),--模块编码
	 name nvarchar(200),--模块名称
	 desc nvarchar(200)--模块描述
)
go
--权限定义表
create table right(
    id int,
	code int,--权限编码
	name nvarchar(200) ,--权限名称
	desc nvarchar(200) ,--权限描述
	businessModuleTpl int --所属业务模块定义id
)
go
--业务模块实例表
create table business_module_instance(
     id int,
	 code nvarchar(200),--模块编码
	 name nvarchar(200),--模块名称
	 desc nvarchar(200)--模块描述
)
go
--权限分配表
create table right_assign(
    id int,
	businessModuleInstance int,--权限业务模块实例id
	businessModuleTemplate int,--权限业务模块模板id
	right int,--权限项编码
	subject int,--权限所有者对象id
	subjectType int,--权限所有者类别 
	grantType int--授权类型： 0：拒绝 1：允许
)