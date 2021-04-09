<template>
    <div class="navbar">
        <ul>
            <the-side-bar-item v-for="navbar in navbars" 
            :key="navbar.link" v-bind:to="navbar.link">
                    <img :src="require(`./../../assets/icon/${navbar.img}`)" 
                    alt="" slot="sidebar-icon">
                {{navbar.name}}
            </the-side-bar-item>
        </ul>
    </div>
</template>
<script>
import TheSideBarItem from './TheSideBarItem.vue'
export default {
    
    components:{
        TheSideBarItem

    },
    data() {
        return {
            navbars:[
                {
                    img: "employee.svg",
                    link: "employee",
                    name: "Quản lý nhân viên",
                },
                {
                    img: "customer.png",
                    link: "customer",
                    name: "Quản lý khách hàng",
                },
                {
                    img: "product.svg",
                    link: "product",
                    name: "Quản lý sản phẩm",
                },
                {
                    img: "coupon.svg",
                    link: "coupons",
                    name: "Quản lý khuyến mãi",
                },
                {
                    img: "order.svg",
                    link: "order",
                    name: "Đơn hàng",
                },
                {
                    img: "account.svg",
                    link: "account",
                    name: "Quản lý tài khoản",
                },
                
            ]
        }
    },
}
</script>
<style scoped>
.navbar{
    width: 20%;
    height: 550px;
    float: left;
    border-right: 1px solid #e5e5e5;
}
.navbar ul{
    width: 100%;
    margin-left: -40px;
    margin-top: 0px;
    list-style: none;
}
.navbar-icon img{
    line-height: 50px;
    width: 20px;
    height: 20px;
    margin: 14px 10px;
    opacity: 0.8;
}
.navbar-icon ul li{
    text-decoration: none;
    list-style: none;
    height: 50px;
    font-size: 16px;
    cursor: pointer;
}
.navbar ul li:hover{
    background: #e5e5e5;
}
.navbar ul li:active{
    background: #019160;
}
</style>