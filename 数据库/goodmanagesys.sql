/*
 Navicat Premium Data Transfer

 Source Server         : my
 Source Server Type    : MySQL
 Source Server Version : 80015
 Source Host           : localhost:3306
 Source Schema         : goodmanagesys

 Target Server Type    : MySQL
 Target Server Version : 80015
 File Encoding         : 65001

 Date: 07/03/2019 14:34:00
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category`  (
  `categoryID` int(11) NOT NULL AUTO_INCREMENT,
  `categoryName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `parentCategoryID` int(11) NULL DEFAULT NULL,
  `parentCategoryName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `unit` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `color` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `firm` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `minStock` int(11) NULL DEFAULT NULL,
  `maxStock` int(11) NULL DEFAULT NULL,
  `expirationDate` int(11) NULL DEFAULT NULL,
  `isValid` tinyint(1) NULL DEFAULT NULL,
  PRIMARY KEY (`categoryID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `categoryID_2`(`categoryID`) USING BTREE,
  INDEX `categoryID_3`(`categoryID`) USING BTREE,
  INDEX `categoryID_4`(`categoryID`) USING BTREE,
  INDEX `categoryID_5`(`categoryID`) USING BTREE,
  INDEX `categoryID_6`(`categoryID`) USING BTREE,
  INDEX `categoryID_7`(`categoryID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19023 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES (19001, '统一冰红茶', 1, '饮料', '瓶', '澄', '统一', 12, 120, 6, 0);
INSERT INTO `category` VALUES (19002, '康师傅绿茶', 1, '饮料', '瓶', '绿', '康师傅', 12, 120, 12, 0);
INSERT INTO `category` VALUES (19003, '娃哈哈矿泉水', 1, '饮料', '瓶', '透明', '娃哈哈', 10, 100, 12, 0);
INSERT INTO `category` VALUES (19004, '太谷饼', 4, '糕饼', '袋', NULL, NULL, 5, 20, 12, 0);
INSERT INTO `category` VALUES (19005, '五粮液', 2, '酒', '瓶', '透明', '五粮液', 3, 12, 18, 0);
INSERT INTO `category` VALUES (19006, '中华', 3, '香烟', '盒', '红', '中华', 4, 20, 24, 0);
INSERT INTO `category` VALUES (19007, '真知棒棒棒糖', 5, '糖果', '根', NULL, '真知棒', 5, 100, 6, 0);
INSERT INTO `category` VALUES (19008, '蒙牛纯牛奶', 6, '奶制品', '盒', '白', '蒙牛', 3, 12, 3, 0);
INSERT INTO `category` VALUES (19009, '乐事薯片', 7, '休闲食品', '袋', NULL, '乐事', 5, 20, 6, 0);
INSERT INTO `category` VALUES (19010, '乐事薯片', 7, '休闲食品', '桶', '', '乐事', 10, 20, 6, 1);
INSERT INTO `category` VALUES (19018, 'QQ糖', 5, '糖果', '袋', '', '旺仔', 15, 30, 6, 1);
INSERT INTO `category` VALUES (19019, '怡宝', 1, '饮料', '瓶', '澄', '怡宝', 10, 20, 6, 0);
INSERT INTO `category` VALUES (19020, '奥利奥', 7, '休闲食品', '盒', '黑', '奥利奥', 12, 24, 12, 0);
INSERT INTO `category` VALUES (19021, '可乐', 1, '饮料', '瓶', '黑', '', 12, 12, 6, 0);
INSERT INTO `category` VALUES (19022, '飒飒', 3, '香烟', '', '', '', 6, 7, 5, 0);

-- ----------------------------
-- Table structure for good
-- ----------------------------
DROP TABLE IF EXISTS `good`;
CREATE TABLE `good`  (
  `goodID` int(11) NOT NULL AUTO_INCREMENT,
  `categoryID` int(11) NULL DEFAULT NULL,
  `productionDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `purchaseDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cost` double NULL DEFAULT NULL,
  `price` double NULL DEFAULT NULL,
  `state` tinyint(2) NULL DEFAULT NULL,
  PRIMARY KEY (`goodID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `goodID`(`goodID`) USING BTREE,
  CONSTRAINT `good_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1021 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of good
-- ----------------------------
INSERT INTO `good` VALUES (1001, 19001, '20190227', '20190228', 1, 0, 1);
INSERT INTO `good` VALUES (1002, 19001, '20190227', '20190228', 1, 2.5, 0);
INSERT INTO `good` VALUES (1003, 19003, '20190219', '20190220', 3, 0, 2);
INSERT INTO `good` VALUES (1004, 19003, '20190227', '20190228', 4, 0, 1);
INSERT INTO `good` VALUES (1005, 19003, '20190219', '20190220', 3, 3.5, 0);
INSERT INTO `good` VALUES (1006, 19006, '20190219', '20190221', 10, 300, 2);
INSERT INTO `good` VALUES (1007, 19008, '20190226', '20190228', 15, 20, 0);
INSERT INTO `good` VALUES (1010, 19001, '91020301', '91020301', 8, 9.99, 2);
INSERT INTO `good` VALUES (1011, 19001, '20190301', '20190307', 2, 0, 2);
INSERT INTO `good` VALUES (1012, 19001, '20190301', '20190307', 2, 3, 2);
INSERT INTO `good` VALUES (1013, 19001, '20190301', '20190307', 2, 3, 2);
INSERT INTO `good` VALUES (1014, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1015, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1016, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1017, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1018, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1019, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1020, 19001, '20190301', '20190307', 2, 0, 1);
INSERT INTO `good` VALUES (1021, 19005, '20190307', '20190307', 90, 0, 1);
INSERT INTO `good` VALUES (1022, 19005, '20190307', '20190307', 90, 0, 1);
INSERT INTO `good` VALUES (1023, 19005, '20190307', '20190307', 90, 0, 1);
INSERT INTO `good` VALUES (1024, 19006, '20190307', '20190307', 80, 0, 1);
INSERT INTO `good` VALUES (1025, 19006, '20190307', '20190307', 80, 0, 1);

-- ----------------------------
-- Table structure for membership
-- ----------------------------
DROP TABLE IF EXISTS `membership`;
CREATE TABLE `membership`  (
  `msID` int(11) NOT NULL AUTO_INCREMENT,
  `msName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `msPhone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `msPoint` int(11) NULL DEFAULT NULL,
  `isValid` tinyint(1) NULL DEFAULT NULL,
  PRIMARY KEY (`msID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 29011 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of membership
-- ----------------------------
INSERT INTO `membership` VALUES (29001, '张三', '13813813888', 80, 1);
INSERT INTO `membership` VALUES (29002, '王丽', '17312812931', 0, 0);
INSERT INTO `membership` VALUES (29003, '李帅', '15712132123', 90, 0);
INSERT INTO `membership` VALUES (29004, '赵武', '13912312389', 0, 0);
INSERT INTO `membership` VALUES (29005, '周山', '17912839472', 10, 1);
INSERT INTO `membership` VALUES (29006, 'test', '12345678987', 89, 0);
INSERT INTO `membership` VALUES (29007, '张三', '13813813888', 80, 0);
INSERT INTO `membership` VALUES (29008, '张三', '13813813888', 80, 0);
INSERT INTO `membership` VALUES (29009, '张三', '13813813888', 80, 0);
INSERT INTO `membership` VALUES (29010, 'qian', '21312432411', 12, 0);

-- ----------------------------
-- Table structure for purchase
-- ----------------------------
DROP TABLE IF EXISTS `purchase`;
CREATE TABLE `purchase`  (
  `purchaseID` int(11) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `purchaseDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `quantity` int(11) NULL DEFAULT NULL,
  `cost` double NULL DEFAULT NULL,
  `staffID` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`purchaseID`, `categoryID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  CONSTRAINT `purchase_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `purchase_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of purchase
-- ----------------------------
INSERT INTO `purchase` VALUES (22001, 19001, '20190228', 2, 2, 18004);
INSERT INTO `purchase` VALUES (22001, 19003, '20190228', 1, 4, 18004);
INSERT INTO `purchase` VALUES (22001, 19008, '20190228', 1, 15, 18004);
INSERT INTO `purchase` VALUES (22002, 19003, '20190220', 2, 6, 18005);
INSERT INTO `purchase` VALUES (22003, 19001, '20190221', 20, 2, 18005);
INSERT INTO `purchase` VALUES (22003, 19006, '20190221', 1, 10, 18005);
INSERT INTO `purchase` VALUES (22004, 19001, '20190301', 20, 2, 18006);
INSERT INTO `purchase` VALUES (22004, 19002, '20190301', 3, 2, 18006);
INSERT INTO `purchase` VALUES (22004, 19003, '20190301', 3, 2, 18006);
INSERT INTO `purchase` VALUES (22006, 19001, '20190307', 10, 2, 18004);
INSERT INTO `purchase` VALUES (22007, 19005, '20190307', 3, 90, 18005);
INSERT INTO `purchase` VALUES (22007, 19006, '20190307', 2, 80, 18005);

-- ----------------------------
-- Table structure for sale
-- ----------------------------
DROP TABLE IF EXISTS `sale`;
CREATE TABLE `sale`  (
  `saleID` int(11) NOT NULL,
  `goodID` int(11) NOT NULL,
  `saleDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `profit` double NULL DEFAULT NULL,
  `staffID` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`saleID`, `goodID`) USING BTREE,
  INDEX `goodID`(`goodID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  CONSTRAINT `sale_ibfk_1` FOREIGN KEY (`goodID`) REFERENCES `good` (`goodID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `sale_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sale
-- ----------------------------
INSERT INTO `sale` VALUES (6001, 1002, '20190301', 1.5, 18002);
INSERT INTO `sale` VALUES (6001, 1005, '20190301', 0.5, 18002);
INSERT INTO `sale` VALUES (6002, 1003, '20190302', 2, 18003);
INSERT INTO `sale` VALUES (6002, 1007, '20190302', 5, 18003);
INSERT INTO `sale` VALUES (6003, 1012, '20190307', 1, 18002);
INSERT INTO `sale` VALUES (6004, 1006, '20190307', 290, 18002);
INSERT INTO `sale` VALUES (6005, 1013, '20190307', 1, 18002);

-- ----------------------------
-- Table structure for staff
-- ----------------------------
DROP TABLE IF EXISTS `staff`;
CREATE TABLE `staff`  (
  `staffID` int(11) NOT NULL AUTO_INCREMENT,
  `staffName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `pwd` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `staffPhone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `role` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`staffID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  INDEX `staffID_2`(`staffID`) USING BTREE,
  INDEX `staffID_3`(`staffID`) USING BTREE,
  INDEX `staffID_4`(`staffID`) USING BTREE,
  INDEX `staffID_5`(`staffID`) USING BTREE,
  INDEX `staffID_6`(`staffID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 18013 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of staff
-- ----------------------------
INSERT INTO `staff` VALUES (18002, '小李', '81DC9BDB52D04DC20036DBD8313ED055', '18312398923', 1);
INSERT INTO `staff` VALUES (18003, '小白', '81B073DE9370EA873F548E31B8ADC081', '18943286543', 2);
INSERT INTO `staff` VALUES (18004, '小周', 'DEF7924E3199BE5E18060BB3E1D547A7', '17816734679', 3);
INSERT INTO `staff` VALUES (18005, '小赵', '25D55AD283AA400AF464C76D713C07AD', '13413453246', 3);
INSERT INTO `staff` VALUES (18006, '小罗', 'DB1F7A16EE467682CF0D5CF125EF0E18', '13978164738', 2);
INSERT INTO `staff` VALUES (18007, '小张', '6D030E0DCCCB5649D6F34431CA2555C4', '18120745639', 2);
INSERT INTO `staff` VALUES (18008, '小黄', 'E10ADC3949BA59ABBE56E057F20F883E', '123456', 1);
INSERT INTO `staff` VALUES (18009, '小王', 'E10ADC3949BA59ABBE56E057F20F883E', '1231231232', 1);

SET FOREIGN_KEY_CHECKS = 1;
