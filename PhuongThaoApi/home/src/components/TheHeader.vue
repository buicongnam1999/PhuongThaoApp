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
    top: 50px;
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
}
.language-dropdown ul li:hover{
    color: red;
    background: #f5f5f5;
}

.language-dropdown-content , .setting-dropdown-content{
    margin-top: 10px;
    border: 1px ridge;
}



</style>