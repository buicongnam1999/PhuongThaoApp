USE [PhuongThaoShop]
GO
/****** Object:  Table [dbo].[tblblog]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblblog](
	[blog_id] [int] IDENTITY(1,1) NOT NULL,
	[blog_title] [nvarchar](100) NOT NULL,
	[blog_create_at] [date] NOT NULL,
	[blog_content] [nvarchar](300) NULL,
	[u_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[blog_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcart]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcart](
	[cart_id] [int] IDENTITY(1,1) NOT NULL,
	[u_id] [int] NOT NULL,
	[cart_note] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcartdetail]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcartdetail](
	[cart_id] [int] NOT NULL,
	[food_id] [int] NOT NULL,
	[quality] [int] NOT NULL,
	[cart_status] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcomment]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcomment](
	[comment_id] [int] IDENTITY(1,1) NOT NULL,
	[u_id] [int] NOT NULL,
	[food_id] [int] NOT NULL,
	[content] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcoupons]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcoupons](
	[cou_id] [int] IDENTITY(1,1) NOT NULL,
	[cou_number] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cou_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblfood]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblfood](
	[food_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_id] [int] NOT NULL,
	[food_code] [varchar](20) NOT NULL,
	[food_name] [nvarchar](50) NOT NULL,
	[food_img] [varchar](30) NULL,
	[food_money] [float] NOT NULL,
	[food_quality] [int] NOT NULL,
	[food_type] [smallint] NOT NULL,
	[cou_id] [int] NOT NULL,
	[food_status] [bit] NOT NULL,
	[food_count_order] [int] NOT NULL,
	[food_description] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[food_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorder]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorder](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [datetime] NULL,
	[order_note] [nvarchar](300) NOT NULL,
	[u_id] [int] NOT NULL,
	[order_status] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorderdetail]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorderdetail](
	[order_id] [int] NOT NULL,
	[food_id] [int] NOT NULL,
	[quality] [int] NOT NULL,
	[order_status] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsupplier]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsupplier](
	[sup_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_name] [nvarchar](30) NULL,
	[sup_email] [varchar](30) NOT NULL,
	[sup_phone] [varchar](12) NOT NULL,
	[sup_address] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbluser]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbluser](
	[u_id] [int] IDENTITY(1,1) NOT NULL,
	[user_fullname] [nvarchar](50) NOT NULL,
	[user_gender] [bit] NOT NULL,
	[user_phone] [varchar](12) NOT NULL,
	[user_email] [varchar](30) NOT NULL,
	[user_address] [nvarchar](100) NOT NULL,
	[u_name] [varchar](20) NOT NULL,
	[user_pass] [varchar](20) NOT NULL,
	[user_type] [smallint] NOT NULL,
	[user_status] [bit] NOT NULL,
	[user_img] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblblog]  WITH CHECK ADD  CONSTRAINT [f_b_u] FOREIGN KEY([u_id])
REFERENCES [dbo].[tbluser] ([u_id])
GO
ALTER TABLE [dbo].[tblblog] CHECK CONSTRAINT [f_b_u]
GO
ALTER TABLE [dbo].[tblcart]  WITH CHECK ADD  CONSTRAINT [f_cart_u] FOREIGN KEY([u_id])
REFERENCES [dbo].[tbluser] ([u_id])
GO
ALTER TABLE [dbo].[tblcart] CHECK CONSTRAINT [f_cart_u]
GO
ALTER TABLE [dbo].[tblcartdetail]  WITH CHECK ADD  CONSTRAINT [f_c_b] FOREIGN KEY([food_id])
REFERENCES [dbo].[tblfood] ([food_id])
GO
ALTER TABLE [dbo].[tblcartdetail] CHECK CONSTRAINT [f_c_b]
GO
ALTER TABLE [dbo].[tblcartdetail]  WITH CHECK ADD  CONSTRAINT [f_c_c] FOREIGN KEY([cart_id])
REFERENCES [dbo].[tblcart] ([cart_id])
GO
ALTER TABLE [dbo].[tblcartdetail] CHECK CONSTRAINT [f_c_c]
GO
ALTER TABLE [dbo].[tblcomment]  WITH CHECK ADD  CONSTRAINT [f_c_f] FOREIGN KEY([food_id])
REFERENCES [dbo].[tblfood] ([food_id])
GO
ALTER TABLE [dbo].[tblcomment] CHECK CONSTRAINT [f_c_f]
GO
ALTER TABLE [dbo].[tblcomment]  WITH CHECK ADD  CONSTRAINT [f_c_u] FOREIGN KEY([u_id])
REFERENCES [dbo].[tbluser] ([u_id])
GO
ALTER TABLE [dbo].[tblcomment] CHECK CONSTRAINT [f_c_u]
GO
ALTER TABLE [dbo].[tblfood]  WITH CHECK ADD  CONSTRAINT [fk_f_c] FOREIGN KEY([cou_id])
REFERENCES [dbo].[tblcoupons] ([cou_id])
GO
ALTER TABLE [dbo].[tblfood] CHECK CONSTRAINT [fk_f_c]
GO
ALTER TABLE [dbo].[tblfood]  WITH CHECK ADD  CONSTRAINT [fk_f_s] FOREIGN KEY([sup_id])
REFERENCES [dbo].[tblsupplier] ([sup_id])
GO
ALTER TABLE [dbo].[tblfood] CHECK CONSTRAINT [fk_f_s]
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [f_o_u] FOREIGN KEY([u_id])
REFERENCES [dbo].[tbluser] ([u_id])
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [f_o_u]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [f_o_f] FOREIGN KEY([food_id])
REFERENCES [dbo].[tblfood] ([food_id])
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [f_o_f]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [f_o_o] FOREIGN KEY([order_id])
REFERENCES [dbo].[tblorder] ([order_id])
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [f_o_o]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Blog]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Insert_Blog](@blog_title nvarchar(100) ,@blog_create_at date ,@blog_content nvarchar(300),@u_id int)
AS
	BEGIN
		INSERT tblblog(blog_title ,blog_create_at ,blog_content,u_id ) VALUES(@blog_title ,@blog_create_at ,@blog_content,@u_id)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Cart]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Insert_Cart](@u_id int,@cart_note nvarchar(300))
AS
	BEGIN
		INSERT INTO tblcart(u_id,cart_note) VALUES(@u_id,@cart_note)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Comment]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Insert_Comment](@u_id int, @food_id int, @content nvarchar(300))
AS
	BEGIN
		INSERT tblcomment(u_id,food_id,content) VALUES(@u_id,@food_id,@content)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Coupons]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC	[dbo].[Insert_Coupons](@cou_number int)
AS
	BEGIN
		INSERT tblcoupons(cou_number) VALUES(@cou_number)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Food]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Food](@sup_id int,@food_code varchar(20),@food_name nvarchar(50),@food_img varchar(30),@food_money float
,@food_quality int,@food_type smallint,@cou_id int,@food_status bit,@food_count_order int, @food_description nvarchar(300))
AS
	BEGIN
		INSERT INTO tblfood(sup_id ,food_code,food_name,food_img,food_money,food_quality,food_type,cou_id,food_status,food_count_order,food_description)
		VALUES(@sup_id,@food_code,@food_name,@food_img,@food_money,@food_quality,@food_type,@cou_id,@food_status,@food_count_order, @food_description)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Order]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Insert_Order](@order_date date, @order_note nvarchar (300), @u_id int, @order_status smallint)
AS
	BEGIN
		INSERT tblorder(order_date,order_note,u_id,order_status) VALUES(@order_date,@order_note,@u_id,@order_status)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_OrderDetail]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Insert_OrderDetail](@order_id int, @food_id int, @quality int, @order_status bit)
AS
	BEGIN
		INSERT tblorderdetail(order_id,food_id,quality,order_status) VALUES(@order_id,@food_id,@quality,@order_status)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Supplier]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Insert_Supplier](@sup_id int,@sup_name nvarchar(30),@sup_email varchar(30),@sup_phone varchar(12), @sup_address varchar(100))
AS
	BEGIN
		INSERT tblsupplier(sup_id,sup_name,sup_email,sup_phone,sup_address) VALUES(@sup_id,@sup_name,@sup_email,@sup_phone,@sup_address)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_User]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_User](@user_fullname nvarchar(50),@user_gender bit,@user_phone varchar(12),@user_email varchar(30),@user_address nvarchar(100)
,@u_name varchar(20),@user_pass varchar(20),@user_type smallint,@user_status bit,@user_img varchar(30))
AS
	BEGIN
		INSERT INTO tbluser(user_fullname,user_gender,user_phone,user_email,user_address,u_name,user_pass,user_type,user_status,user_img )
		VALUES(@user_fullname,@user_gender,@user_phone,@user_email,@user_address,@u_name,@user_pass,@user_type,@user_status,@user_img)
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_Cart]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Cart](@cart_id int, @u_id int, @cart_date date,@cart_note nvarchar(300))
AS
	BEGIN
		Update tblcart set u_id=@u_id, cart_date=@cart_date, cart_note=@cart_note
		where cart_id=@cart_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_CartDetail]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Update_CartDetail](@cart_id int, @food_id int, @quality int, @cart_status bit)
AS
	BEGIN
		
		Update tblcartdetail set quality=@quality,cart_status=@cart_status
		where cart_id=@cart_id and food_id =@food_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_Coupons]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Update_Coupons](@cou_id int, @cou_number int)
AS
	BEGIN
		Update tblcoupons set cou_number=@cou_number
		where cou_id=@cou_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_Food]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Food](@food_id int,@sup_id int,@food_code varchar(20),@food_name nvarchar(50),@food_img varchar(30),@food_money float
,@food_quality int,@food_type smallint,@cou_id int,@food_status bit,@food_count_order int, @food_description nvarchar(300))
AS
	BEGIN
		UPDATE tblfood SET sup_id = @sup_id,food_code = @food_code,food_name = @food_name,food_img = @food_img,food_money = @food_money,food_quality = @food_quality,food_type = @food_type,cou_id = @cou_id,food_status = @food_status,food_count_order = @food_count_order,food_description = @food_description
		WHERE food_id = @food_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_Order]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Order](@order_id int,@cart_id int, @order_date date, @order_note nvarchar (300), @u_id int)
AS
	BEGIN
		Update tblorder set cart_id=@cart_id,order_date=@order_date, order_note=@order_note,u_id=@u_id
		where order_id=@order_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_OrderDetail]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Update_OrderDetail](@order_id int, @food_id int, @quality int, @order_status bit)
AS
	BEGIN
		Update tblorderdetail set quality=@quality,order_status=@order_status
		where order_id=@order_id and food_id = @food_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Update_Supplier]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_Supplier]
@sup_id int,
@sup_name nvarchar(30),
@sup_email varchar(30),
@sup_phone varchar(12),
@sup_address varchar(100) 
AS 
BEGIN 
UPDATE tblsupplier 
SET sup_name =  @sup_name, sup_email = @sup_email, sup_phone=@sup_phone, sup_address=@sup_address
WHERE sup_id = @sup_id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_User]    Script Date: 4/11/2021 10:45:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_User](@u_id int,@user_fullname nvarchar(50),@user_gender bit,@user_phone varchar(12),@user_email varchar(30),@user_address nvarchar(100)
,@u_name varchar(20),@user_pass varchar(20),@user_type smallint,@user_img varchar(30))
AS
	BEGIN
		UPDATE tbluser SET user_fullname = @user_fullname,user_gender = @user_gender,user_phone = @user_phone,
		user_email = @user_email, user_address = @user_address, u_name = @u_name, user_pass = @user_pass, user_type = @user_type,
		user_img = @user_img
		WHERE u_id = @u_id
	END
GO
