<template>
    <div class="header">
        <div class="header-logo">
            <div class="header-logo-image">
                <img src="../assets/img/logo/logo.png" alt="" srcset="">
            </div>
            <div class="header-log-text">
                <b>PHUONG THAO</b>
            </div>
            <div class="header-logo-icon">
                <img src="../assets/icon/common.svg" alt="" srcset="">
            </div>
        </div>
        <div class="header-info">
            <div class="header-info-left">
                PHUONG THAO SHOP
            </div>
            <div class="header-info-right">
                <div class="help">
                    <img src="../assets/icon/help.svg" alt="" srcset="">
                </div>
                <div class="border-setting">
                </div>
                <div class="info-image">
                    <img src="../assets/icon/batman_hero_avatar_comics-512.webp" alt="" srcset="">
                    <div class="info-user">
                        Bùi Công Nam
                    </div>
                </div>
                <div class="info-setting">
                    <img src="../assets/icon/i_arrow_up_small.svg" alt="" srcset="" @click="openDialog">
                    <ul :class="{isHide: isHide}">
                        <li @click="logOut">Đăng xuất</li>
                        <div class="border-list"></div>
                        <li>Thông tin cá nhân</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            isHide: true
        }   
    },
    components:{

    },
    methods: {
        openDialog: function(){
            this.isHide = !this.isHide;
        },
        logOut: function(){
            this.$emit('Logout')
        }
    },
}
</script>
<style scoped>
.header{
    height: 70px;
    width: 100%;
    display: flex;
}
.header-logo{
    background: #019160;
    width: 20.05%;
    display: flex;
}

.header-logo-image img{
    margin-left: 10px;
    height: 40px;
    width: 40px;
    margin-top: 15px;
}
.header-log-text{
    color: white;
    line-height: 70px;
    margin-left: 10px;
    width: 160px;
    font-family: OpenSans-Sbold;
    font-weight: bold;
    font-size: 20px;
}
.header-logo-icon img{
    margin-top: 20px;
    height: 30px;
    width: 30px;
}
.header-info{
    width: 80%;
    border-bottom: 1px solid #e5e5ee;
    display: flex;
}
.header-info-left{
    line-height: 70px;
    margin-left: 20px;
    font-family: OpenSans-Sbold;
    justify-content: flex-end;
    width: 50%;
}
.header-info-right{
    width: 50%;
    display: flex;
    justify-content: flex-end;
    padding-right: 20px;
    line-height: 70px;
}
.info-image{
    display: flex;
    font-size: 14px;
    line-height: 75px;
    margin-right: 10px;
}
.info-image img{
    height: 30px;
    width: 30px;
    margin-top: 20px;
    margin-right: 10px;
    cursor: pointer;
}
.border-setting{
    margin-top: 22.5px;
    border-right: 2px solid #e5e5ee;
    height: 25px;
    margin-right: 10px;
}
.help{
    margin-top: 5px;
    margin-right: 15px;
}
.info-setting img{
    opacity: 0.5;
    cursor: pointer;
}
.info-setting{
    height: 0px;
    width: 0px;
}
.info-setting ul{
    position: absolute;
    z-index: 1;
    opacity: 1;
    width: 90px;
    right: 0px;
    top: 25px;
    height: 50px;
    border: 2px solid #e5e5e5;
    border-radius: 3px;
    background: white;
}
.info-setting ul li{
    list-style: none;
    font-size: 13px;
    color: black;
    height: 25px;
    line-height: 30px;
    margin-left: -30px;
    cursor: pointer;
}
.info-setting ul li:active{
    color: red;
    opacity: 0.8;
}
.isHide{
    display: none;
}
.border-list{
    border-top: 1px solid #e5e5e5;
    width: 150px;
    margin-left: -40px;
}
</style>