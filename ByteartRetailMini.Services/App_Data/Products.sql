/*
Navicat SQLite Data Transfer

Source Server         : ByteMini
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-02-08 23:51:17
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for Products
-- ----------------------------
DROP TABLE IF EXISTS "main"."Products";
CREATE TABLE Products (ID UNIQUEIDENTIFIER not null, Name TEXT not null, ImageUrl TEXT, UnitPrice NUMERIC not null, IsFeatured BOOL not null, Description TEXT not null, primary key (ID));

-- ----------------------------
-- Records of Products
-- ----------------------------
INSERT INTO "main"."Products" VALUES ('973A3217-F504-4842-A7A0-2CBBD8E561DA', 'ZTE 中兴 V970 3G手机', 'dd34e809_b1fc_4c75_b8f9_c5444a64cb47.jpg', 975, 0, 'ZTE 中兴 V970 3G手机(黑色)WCDMA/GSM 双卡双待安卓4.0+1GHz双核处理器+4.3寸QHD高清大屏');
INSERT INTO "main"."Products" VALUES ('556AA854-41B1-4D99-8419-3CE5CF902E9A', 'ZTE 中兴 V889M', 'a1c1738a_eaba_4c4c_b683_7c5b4eb64306.jpg', 784, 0, 'ZTE 中兴 V889M 智能双卡双待3G手机(黑)联通定制 1GHz双核处理器 4.0英寸超大炫屏');
INSERT INTO "main"."Products" VALUES ('091C2CA8-6B5E-4268-A471-402F12DE7257', 'DELL 戴尔 V260SR-526 台式电脑', '43dd3fe6_4203_41dd_b570_2c9eacb7c021.jpg', 2749, 0, 'DELL 戴尔 V260SR-526 台式电脑(G630 2G 500G DVD Linux 18.5英寸宽屏液晶 三年上门服务)。选择节约空间、使用与拥有同样简单的台式机，简化您的工作空间。Vostro成就260s超薄塔式机可配备第2代英特尔®酷睿™处理器，以及将普通办公室转变为动态工作环境所需的必要组件。');
INSERT INTO "main"."Products" VALUES ('5AD2DC87-111A-4C8B-9A84-4750ABF5032F', '惠普6460B（WX560AV）', 'b182e978_85e1_474d_84e3_e505441e9000.jpg', 6900, 1, 'CPU型号：Intel 酷睿i5 2520M; 屏幕尺寸：14英寸; 内存容量：2GB; 硬盘容量：320GB');
INSERT INTO "main"."Products" VALUES ('441C61C5-7332-41E4-B432-64326F2DBB0F', 'Lenovo 联想 IdeaCentre Q180', '2d3df03f_0663_4f9a_8f6c_cb0af683cd23.jpg', 1799, 0, 'Lenovo 联想 IdeaCentre Q180 台式电脑主机(凌动D2700 2G 320G 512M独显 无线网卡 WIN7 2年保修含1年上门)');
INSERT INTO "main"."Products" VALUES ('AF114C11-FD1F-4759-B0D7-666D438FEFD6', '联想ThinkPad Tablet 2', '774f83b1_e90d_4ff1_a148_f90af591a865.jpg', 6480, 1, '操作系统：Windows 8屏幕尺寸：10.1英寸处理器：Intel Atom摄像头：双摄像头（前置：200屏幕分辨：1366x768WiFi功能：WIFI无线上网续航时间：10小时左右，具体时间上市时间：2012年声音系统：双立体声扬声器，内置屏幕描述：电容式触摸屏，多点式');
INSERT INTO "main"."Products" VALUES ('5C04766F-ED08-4427-B3F0-798BFC021232', '三星GALAXY Tab P6800', 'd633a09b_479f_4af2_af9d_635b7a59e1b7.jpg', 3599, 1, '操作系统：Android3.2屏幕尺寸：7.7英寸系统内存：1GB存储容量：16GB处理器：双核，1.4GHz摄像头：双摄像头（前置：200网络模式：支持3G网络屏幕分辨：1280x800GPS导航：内置GPS导航WiFi功能：支持802.11a/b/g/n无');
INSERT INTO "main"."Products" VALUES ('F7C2A2DD-5453-49C4-A6F8-94E049B408DE', '联想G460A-PSI', 'bc2dbf1a_699a_4eaf_a49f_4eccc199bb55.jpg', 3360, 1, 'CPU型号：Intel 奔腾双核 P6200屏幕尺寸：14英寸内存容量：2GB硬盘容量：320GBCPU主频：2.13GHz笔记本重：2.2Kg');
INSERT INTO "main"."Products" VALUES ('2986F586-03FF-470D-BC48-98775056998B', '联想G470A-IFI', 'c9285a49_972c_4356_a893_3e2a4e45c17d.jpg', 3465, 1, 'CPU型号：Intel 酷睿i5 2450M屏幕尺寸：14英寸内存容量：2GB硬盘容量：500GBCPU主频：2.5GHz笔记本重：2.2Kg');
INSERT INTO "main"."Products" VALUES ('1CE92B9E-9D6E-4345-AD89-A43D58939172', 'SAMSUNG 三星S7562', '333c0de9_cae2_4458_a675_3560e8525ae5.jpg', 1578, 0, 'SAMSUNG 三星S7562双卡3G智能手机(白)Android 4.0操作系统 4.0英寸大屏 1GHz处理器');
INSERT INTO "main"."Products" VALUES ('5BA927AF-0016-475C-8617-B2DC0B01F9C0', '惠普LaserjetM1005黑白激光一体机', 'dafeaaed_0b93_45ea_8b04_00dd86c62d5e.jpg', 1459, 1, 'HP 惠普  LaserjetM1005 黑白激光一体机(打印 扫描 复印)。');
INSERT INTO "main"."Products" VALUES ('FA9BF134-EE4D-4CBD-BA82-B718EB140DF6', '惠普G42-382TX（XU766PA）', 'bc0d0d76_3d79_472e_86bb_63a9376d2bab.jpg', 3860, 1, 'CPU型号：Intel 酷睿i3 370M屏幕尺寸：14英寸内存容量：2GB硬盘容量：500GBCPU主频：2.4GHz笔记本重：2.2Kg');
INSERT INTO "main"."Products" VALUES ('B2D4480D-BC64-447F-9EE1-D5E1867342A9', '惠普Envy 4-1008tx（B4P51PA）', '29ebfc59_e14a_49bc_9a41_d0796f392475.jpg', 5399, 1, 'CPU型号：Intel 酷睿i5 3317U屏幕尺寸：14英寸内存容量：4GB硬盘容量：500GBCPU主频：1.7GHz笔记本重：1.75Kg');
INSERT INTO "main"."Products" VALUES ('D091265A-81F6-4337-846B-E1D676463DCB', 'NOKIA 诺基亚Lumia 800C', '82d1556f_1238_43ce_a5fd_410cc246162e.jpg', 1585, 1, 'NOKIA 诺基亚Lumia 800C 全新WP系统 时尚智能3G手机(电信定制 WP Mango系统 黑)');
