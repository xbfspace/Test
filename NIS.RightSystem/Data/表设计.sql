create database [NIS.RightSystem]
go
use [NIS.RightSystem]
go
--权限业务模板
create table business_template
(
    id int primary key,
	name nvarchar(200) not null,--业务名称
	code nvarchar(200) not null,--业务编码
	remark nvarchar(200) not null default('')--备注
)
go
--模板权限项
create table [right]
(
    id int primary key,
	name nvarchar(200) not null,--权限名称
	code nvarchar(200) not null,--权限编码
	business_template int not null,--权限所属业务模板
	[priority] int not null default(0),--权限优先级 0：拒绝优先 1：允许优先
	remark nvarchar(200) not null default('')--备注
)
go
--权限业务实例
create table business_instance
(
    id int primary key,
	name nvarchar(200) not null,--业务名称
	code nvarchar(200) not null,--业务编码
	business_template int not null,--采用的权限业务模板
	remark nvarchar(200) not null default('')--备注
)
go
--权限分配表
create table right_assign
(
    id int primary key,
	business_instance int not null,--业务实例
	business_template int not null,--业务模板 冗余
	[right] int not null,--权限项
	[subject] int not null,--分配对象
	subject_type int not null,--对象类型 如用户、角色、组织、职位、职级、组织角色
	grant_type int not null,--授权类型  0：拒绝  1：允许

)
