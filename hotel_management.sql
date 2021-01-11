/*
 Navicat Premium Data Transfer

 Source Server         : 12.17
 Source Server Type    : MySQL
 Source Server Version : 50151
 Source Host           : localhost:3306
 Source Schema         : hotel_management

 Target Server Type    : MySQL
 Target Server Version : 50151
 File Encoding         : 65001

 Date: 11/01/2021 20:50:48
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for check_in
-- ----------------------------
DROP TABLE IF EXISTS `check_in`;
CREATE TABLE `check_in`  (
  `ROOM_NAME` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `ID_CARD` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `IS_PAY` varchar(10) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `STATE` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `IN_TIME` datetime NULL,
  `OUT_TIME` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`ROOM_NAME`, `ID_CARD`, `IN_TIME`) USING BTREE,
  INDEX `ROOM_NAME`(`ROOM_NAME`) USING BTREE,
  INDEX `ID_CARD`(`ID_CARD`) USING BTREE,
  CONSTRAINT `check_in_ibfk_1` FOREIGN KEY (`ROOM_NAME`) REFERENCES `room_management` (`ROOM_NAME`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `check_in_ibfk_2` FOREIGN KEY (`ID_CARD`) REFERENCES `roomer_management` (`ID_CARD`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = gbk COLLATE = gbk_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of check_in
-- ----------------------------
INSERT INTO `check_in` VALUES ('XS101', '123456123456123450', '已付款', '已经退房', '2020-01-02 19:30:01', '2020-01-04 12:12:00');
INSERT INTO `check_in` VALUES ('XS101', '123456123456123451', '已付款', '已经退房', '2020-01-02 18:52:29', '2020-01-03 13:03:00');
INSERT INTO `check_in` VALUES ('XS101', '123456123456123454', '已付款', '已经退房', '2020-01-02 19:07:20', '2020-01-03 12:05:00');
INSERT INTO `check_in` VALUES ('XS101', '123456123456123454', '已付款', '已经退房', '2020-01-02 19:16:40', '2020-01-04 11:11:00');
INSERT INTO `check_in` VALUES ('XS101', '123456123456123456', '已付款', '已经退房', '2020-01-02 18:52:01', '2020-01-03 10:59:00');
INSERT INTO `check_in` VALUES ('XS101', '123456123456123456', '未付款', '正在入住', '2020-01-06 13:06:33', '2020-01-09 11:23:00');
INSERT INTO `check_in` VALUES ('XS102', '123456123456123452', '已付款', '已经退房', '2020-01-02 19:18:42', '2020-01-04 12:02:00');
INSERT INTO `check_in` VALUES ('XS103', '123456123456123455', '已付款', '已经退房', '2020-01-02 19:21:20', '2020-01-04 10:18:00');
INSERT INTO `check_in` VALUES ('XS204', '123456123456123450', '已付款', '已经退房', '2020-01-01 18:07:21', '2020-01-13 11:12:00');
INSERT INTO `check_in` VALUES ('XS204', '123456123456123450', '未付款', '正在入住', '2020-01-06 13:09:04', '2020-01-07 08:58:00');

-- ----------------------------
-- Table structure for room_management
-- ----------------------------
DROP TABLE IF EXISTS `room_management`;
CREATE TABLE `room_management`  (
  `ROOM_ID` int(11) NOT NULL AUTO_INCREMENT,
  `ROOM_NAME` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `PRICE` decimal(10, 0) NULL DEFAULT NULL,
  `KIND` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `STATE` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `REMARK` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ROOM_ID`, `ROOM_NAME`) USING BTREE,
  INDEX `ROOM_NAME`(`ROOM_NAME`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 28 CHARACTER SET = gbk COLLATE = gbk_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of room_management
-- ----------------------------
INSERT INTO `room_management` VALUES (15, 'XS101', 150, '单人间', '入住', '无窗，靠近走廊');
INSERT INTO `room_management` VALUES (16, 'XS102', 320, '大床间', '未入住', '靠近走廊:隔音好');
INSERT INTO `room_management` VALUES (17, 'XS103', 320, '双人间', '未入住', '隔音好');
INSERT INTO `room_management` VALUES (18, 'XS202', 380, '标准间', '未入住', '隔音好');
INSERT INTO `room_management` VALUES (19, 'XS203', 220, '单人间', '维修', '在维修中。。。');
INSERT INTO `room_management` VALUES (20, 'XS204', 220, '单人间', '入住', '窗户朝西');
INSERT INTO `room_management` VALUES (21, 'XS205', 220, '单人间', '未入住', '窗户朝西');
INSERT INTO `room_management` VALUES (22, 'XS206', 220, '标准间单人住', '未入住', '窗户朝西');
INSERT INTO `room_management` VALUES (23, 'XS104', 320, '标准间', '未入住', '窗户朝西');
INSERT INTO `room_management` VALUES (24, 'XS105', 320, '标准间单人住', '未入住', '窗户朝东');
INSERT INTO `room_management` VALUES (25, 'XS106', 320, '三人间', '未入住', '窗户朝东');
INSERT INTO `room_management` VALUES (26, 'XS107', 220, '三人间', '未入住', '窗户朝东');
INSERT INTO `room_management` VALUES (27, 'XS108', 320, '三人间', '未入住', '窗户靠西');

-- ----------------------------
-- Table structure for roomer_management
-- ----------------------------
DROP TABLE IF EXISTS `roomer_management`;
CREATE TABLE `roomer_management`  (
  `ID_CARD` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `NAME` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `PHONE` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `ADDRESS` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `STATE` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `REMARK` varchar(200) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID_CARD`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gbk COLLATE = gbk_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of roomer_management
-- ----------------------------
INSERT INTO `roomer_management` VALUES ('123456123456123450', '厉杰', '12345612345', '武汉', '入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123451', '吴伟帅', '12345612345', '鄂州', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123452', '卢杰', '12345612345', '石家庄', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123453', '黄章晖', '12345612345', '武汉', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123454', '钱观养', '12345612345', '武汉', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123455', '袁予沛', '12345612345', '鄂州', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123456', '王五', '12345612345', '北京', '入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123457', '赵柳', '12345612345', '天津', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123458', '李三', '12345612345', '丽水', '未入住', '');
INSERT INTO `roomer_management` VALUES ('123456123456123459', '李黑', '12345612345', '杭州', '未入住', '');
INSERT INTO `roomer_management` VALUES ('330327119791209120', '陈建南', '12345612345', '温州', '未入住', '');

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `userName` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `password` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `LEVEL` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  `status` varchar(20) CHARACTER SET gbk COLLATE gbk_chinese_ci NULL DEFAULT NULL,
  PRIMARY KEY (`userName`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gbk COLLATE = gbk_chinese_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO `userinfo` VALUES ('testadmin', 'testadmin', NULL, '1');

SET FOREIGN_KEY_CHECKS = 1;
