<template>
    <div class="header">
        <div class="header-top">
            <div class="header-top-info">
                <div class="phone">
                    <i class="fa fa-phone" aria-hidden="true"></i>
                    0387200938
                    </div>
                <div class="email">
                    <i class="fa fa-envelope-open-o" aria-hidden="true"></i>
                    Buicongnam@gmail.com
                </div>
            </div>
            <div class="header-top-logo">
                <router-link to="/"><img src="../assets/img/logo/logo.png" alt=""></router-link>
            </div>
            <div class="header-top-setting">
                <div class="setting">
                    Cài đặt
                    <i class="fa fa-angle-down" aria-hidden="true"></i>
                    <div class="setting-dropdown">
                        <div class="setting-dropdown-content">
                            <ul>
                                <li>Tài khoản</li>
                                <div style="border-top: 1px ridge;"></div>
                                <li>
                                    <router-link to="login">Đăng nhập</router-link>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="header-menu">
            <div class="header-menu-left">
                <router-link class="menu-content-element" to="/">
                    Trang chủ
                </router-link>
                <router-link class="menu-content-element"  to="shop">
                    Cửa hàng
                </router-link>
                <div class="menu-content-down">
                    Sản phẩm
                    <div class="menu-drop-down">
                        <ul>
                            <li><router-link to="shop">Đồ ăn nhanh</router-link></li>
                            <div class="border-bottom"></div>
                            <li><router-link to="shop">Gà</router-link></li>
                            <div class="border-bottom"></div>
                            <li><router-link to="shop">Đồ uống</router-link></li>
                            <div class="border-bottom"></div>
                            <li><router-link to="shop">Hoa quả</router-link></li>
                            <div class="border-bottom"></div>
                            <li><router-link to="shop">Bánh ngọt</router-link></li>
                        </ul>
                    </div>
                </div>
                <router-link class="menu-content-element" to="blog">
                    Bài viết
                </router-link>
                <div class="menu-content-element">
                    Liên hệ
                </div>
            </div>
            <div class="header-menu-right">
                <div class="header-menu-search" @click="openSearch">
                    <img src="../assets/icon/search-interface-symbol.svg" alt="" srcset="">
                        <div class="input-search">
                        <input type="text" name="" id="" placeholder="Tìm kiếm...">
                        <i class="fa fa-search" aria-hidden="true"></i>
                    </div>
                </div>
                <div class="header-menu-cart">
                    <router-link to="cart">
                        <img src="../assets/icon/shopping-cart.svg" alt="" srcset="">
                        <div class="count">
                            <div>
                                {{count}}
                            </div>
                        </div>
                    </router-link>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    data() {
        return {
            count: 0
        }
    },
    methods: {
        openSearch(){
            console.log("a")
        }
    },
    async created() {
        await axios.get("https://localhost:44344/api/cart/count/1")
        .then(res => this.count = res.data)
    },
}
</script>

<style scoped>
/*----------------------------------------*/
/* 3.01 Header Top CSS
/*----------------------------------------*/
.header{
    font-size: 16px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    padding: 15px 0px;
}

.header-top {
    display: flex;
    width: 100%;
    border-bottom: 1px solid #e5e5ee;
}

.header-top-info, .header-top-setting{
    display: flex;
    width: 40%;
    padding: 10px 0px;
}

.phone{
    height: 40px;
    width: 100px;
    line-height: 40px;
    display: flex;
}
.phone i{
    line-height: 42px;
    font-size: 15px;
    justify-content: space-between;
    margin-right:7px;
    margin-left: 25px;
}
.phone:hover{
    color: red;
    cursor: pointer;
}

.email{
    width: 145px;
    height: 40px;
    line-height: 40px;
    margin-left: 55px;
    display: flex;
    font-size: 15px;
}
.email i{
    line-height: 40px;
    font-size: 15px;
    margin-right:7px ;
}
.email:hover{
    color: red;
    cursor: pointer;
}

.header-top-logo{
    width: 10%;
    height: 30px;
    margin-left: 10px;
    text-align: center;
    margin-top: -15px;
}
.header-top-logo img{
    width: 200px;
    height: 75px;
    cursor: pointer;
}

.header-top-setting{
    display: flex;
    width: 45%;
    padding: 10px 0px;
    justify-content: flex-end;
}

.setting, .language{
    display: flex;
    line-height: 40px;
    font-size: 15px;
}
.setting i{
    font-size: 18px;
    line-height: 40px;
    margin-left: 3px;
}
.setting:hover{
    color: red;
    cursor: pointer;
}
.setting:hover .setting-dropdown{
    opacity: 1;
    visibility: visible;
}
.setting-dropdown{
    position: absolute;
    top: 50px;
    right: 50px;
    visibility: hidden;
    opacity: 0;
    transition: visibility 0s, opacity 0.5s linear;
}

.setting-dropdown ul li{
    list-style: none;
    color: black;
    width: 170px;
    padding-left: 20px;
}

.setting-dropdown ul li:hover{
    color: red;
    background: #f5f5f5;
}
.setting-dropdown-content a{
    text-decoration: none;
    color: black;
    width: 100%;
}
.setting-dropdown-content a:hover{
    color: red;
    opacity: 0.8;
}

.input-search{
    position: absolute;
    top: 138px;
    right: 105px;
    z-index: 1;
    -webkit-box-shadow: 2px 2px 11px 0 rgb(0 0 0 / 30%);
    box-shadow: 3px 2px 11px 0 rgb(0 0 0 / 30%);
    height: 34px;
    width: 250px;
    background: rgba(255,255,255, 0.9);
    display: none;
}
.input-search input{
    margin-left: 5px;
    border:none;
    outline: none;
    font-size: 15px;
    height: 28px;
    position: relative;
    top: -26px;
    width: 200px;
    background: rgba(255,255,255, 0.8);
    margin: 3px 5px;
}
.input-search i{
    margin-left: 15px;
    font-size: 15px;
    position: relative;
    top: -26px;
    cursor: pointer;
}
/*
--------------------HEADER-MENU--------------------
*/
.header-menu{
    display: flex;
    height: 86px;
}
.header-menu-left, .header-menu-right{
    margin-top: 15px;
}

/*
-----------------MENU-LEFT-------------------
*/
.header-menu-left{
    display: flex;
    font-size: 20px;
    opacity: 0.8;
    width: 60%;
    line-height: 86px;
    padding-left: 300px;
    justify-content: space-between;
}
.header-menu-left a{
    text-decoration: none;
    color: black;
}
.menu-content-down,.menu-content-element{
    cursor: pointer;
}
.menu-content-element:hover{
    color: red;
}
.menu-content-down:hover .menu-drop-down{
    display: block;
}

.menu-drop-down{
    display: none;
    height: 202px;
    justify-content: none;
}
.menu-drop-down ul{
    justify-content: none;
    background: rgba(240,248,255, 0.8);
    width: 180px;
    border-left: 5px solid #01b075;
    cursor: pointer;
    height: 202px;
    display: block;
    position: absolute;
    margin-top: -25px;
    margin-left: -10px;
    z-index: 5;
}
 .menu-drop-down ul li{
    list-style: none;
    line-height: 40px;
    padding-left: 10px;
}
.menu-drop-down ul li:hover{
    background: rgba(245,245,245, 0.8);
    color: red;
}

.header-menu-right{
    width: 45%;
    display: flex;
    justify-content: flex-end;
    line-height: 86px;
    margin-right: 30px;
}
.header-menu-cart{
    display: flex;
    width: 100px;
}
.header-menu-search img, .header-menu-cart img{
    height: 25px;
    width: 25px;
    padding-right: 20px;
    opacity: 0.8;
    cursor: pointer;
}
.header-menu-cart a{
    text-decoration: none;
}
.count{
    padding: 50px 0;
    height: 25px;
    z-index: 3;
    margin-top: -160px; 
    margin-left: 20px;
}
.header-menu-search:hover .input-search{
    display: block;
}
.border-bottom{
    border-bottom: 1px solid #e5e5ee;
}
</style>