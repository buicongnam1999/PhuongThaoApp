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
                <img src="../assets/img/logo/logo.png" alt="">
            </div>
            <div class="header-top-setting">
                <div class="setting">
                    Setting
                    <i class="fa fa-angle-down" aria-hidden="true"></i>
                    <div class="setting-dropdown">
                        <div class="setting-dropdown-content">
                            <ul>
                                <li>My Account</li>
                                <div style="border-top: 1px ridge;"></div>
                                <li>Sign in</li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="language">
                    <img src="../assets/img/header/1.jpg" alt="" srcset="">
                    English
                    <i class="fa fa-angle-down" aria-hidden="true"></i>
                    <div class="language-dropdown">
                        <div class="language-dropdown-content">
                            <ul>
                                <li style="border-bottom:1px solid ##F5F5F5">
                                    <img src="../assets/img/header/1.jpg" alt="" srcset="">
                                    English
                                </li>
                                <div style="border-top: 1px ridge;"></div>
                                <li>
                                    <img src="../assets/img/header/2.jpg" alt="" srcset="">
                                    Francis
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="header-menu">
            <div class="header-menu-left">
                <router-link class="menu-content-element" to="shopview">
                    Home
                </router-link>
                <div class="menu-content-element">
                    Shop
                </div>
                <div class="menu-content-down">
                    Products
                    <div class="menu-drop-down">
                        <ul>
                            <li>Snacks</li>
                            <div class="border-bottom"></div>
                            <li>Chicken</li>
                            <div class="border-bottom"></div>
                            <li>Drink</li>
                            <div class="border-bottom"></div>
                            <li>Fruit & Nut</li>
                            <div class="border-bottom"></div>
                            <li>Cakes</li>
                        </ul>
                    </div>
                </div>
                <div class="menu-content-element">
                    Blog
                </div>
                <div class="menu-content-element">
                    Contact
                </div>
            </div>
            <div class="header-menu-right">
                <div class="header-menu-search">
                    <img src="../assets/icon/search-interface-symbol.svg" alt="" srcset="">
                </div>
                <div class="header-menu-cart">
                    <img src="../assets/icon/shopping-cart.svg" alt="" srcset="">
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    
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
    padding: 15px;
    text-align: center;
}
.header-top-logo img{
    width: 123px;
    height: 30px;
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
    right: 140px;
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

.language img{
    height: 11px;
    padding-top: 15px;
    margin: 0px 5px 0px 20px;
}
.language i{
    font-size: 18px;
    line-height: 40px;
    margin-left: 3px;
}
.language:hover{
    color: red;
    cursor: pointer;
}
.language:hover .language-dropdown{
    visibility: visible;
    opacity: 1;
}

.language-dropdown{
    position: absolute;
    z-index: 1;
    right: 37px;
    visibility: hidden; 
    opacity: 0;
    transition: visibility 0s, opacity 0.5s linear;
}
.language-dropdown ul li{
    list-style: none;
    color: black;
    width: 180px;
    z-index: 1;
}
.language-dropdown ul li:hover{
    color: red;
    background: #f5f5f5;
}

.language-dropdown-content , .setting-dropdown-content{
    margin-top: 10px;
    border: 1px ridge;
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
    padding-right: 20px;
}
.header-menu-search img, .header-menu-cart img{
    height: 25px;
    width: 25px;
    padding-right: 20px;
    opacity: 0.8;
}

.border-bottom{
    border-bottom: 1px solid #e5e5ee;
}
</style>