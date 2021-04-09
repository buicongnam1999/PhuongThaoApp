<template>
    <div :class="{isHide: isHide}">
        <div class="product-dialog">
            <div class="product-dialog-content">
                <div class="product-dialog-image">
                    <div class="product-image-content">
                        <div v-if="image.length != ''">
                            <img :src="require(`../../assets/img/products/food/${image}`)" alt="" srcset="">
                        </div>
                        <div v-else></div>
                    </div>
                    <div v-if="image.length != ''" style="margin-left:0px;">
                        <div style="margin-left:10px;">
                            <img :src="require(`../../assets/img/products/food/${image}`)" alt="" srcset="" width="96px" height="100px">&nbsp;
                            <img :src="require(`../../assets/img/products/food/${image}`)" alt="" srcset="" width="96px" height="100px">&nbsp;
                            <img :src="require(`../../assets/img/products/food/${image}`)" alt="" srcset="" width="96px" height="100px">
                        </div>
                    </div>
                    <div v-else></div>
                    
                </div>
                <div class="product-dialog-right">
                    <div class="product-dialog-close">
                        <img src="../../assets/icon/cancel.svg" alt="" srcset="" @click="closeDialog">
                    </div>
                    <div class="product-name">
                        {{name}}
                    </div>
                    <div class="product-price">
                        {{price*amount}}
                    </div>
                    <div class="product-note">
                        Miễn Phí Vận Chuyển
                        Miễn Phí Vận Chuyển khi đơn đạt giá trị tối thiểu
                    </div>
                    <div class="product-amount">
                        Số lượng: <button @click="reduction">-</button>&emsp;<input type="number" name="" id="" :value="amount">&emsp;<button @click="increase">+</button>
                    </div>
                    <div class="product-note">
                        {{note}}
                    </div>
                    <div class="btn-add" @click="OpenPopup">
                        Thêm vào giỏ hàng
                    </div>
                </div>
            </div>
        </div>
        <pop-up-basic :isHide="isHidePop">
            <div slot="title">
                Thông báo
            </div>
            <div slot="message">
                Bạn có muốn thêm vào giỏ hàng?
            </div>
            <div slot="button">
                <div class="button-pop">
                    <div class="btn-sucess" @click="Ok">Đồng ý</div>
                    <div class="btn-cancel" @click="Cancel">Hủy bỏ</div>
                </div>
            </div>
        </pop-up-basic>
    </div>
</template>
<script>
import axios from 'axios'
import PopUpBasic from '../base/PopUpBasic.vue'
export default {
    components:{
        PopUpBasic
    },
    data() {
        return {
            img: '1.jpg',
            isHidePop: true,
            amount: 1
        }
    },
    props:{
        id: Number,
        isHide: Boolean,
        image: String,
        name: String,
        price: String,
        note: String
    },
    created: function(){
        this.img = this.image
    },
    methods: {
        closeDialog: function(){
            this.$emit('CloseDialog')
        },
        OpenPopup(){
            this.isHidePop = !this.isHidePop
        },
        Cancel: function(){
            this.isHidePop = true
        },
        async Ok(){
            await axios.post("https://localhost:44344/api/cart/1&&"+this.id)
            .then(res => console.log(res.data))
            this.isHidePop = true
        },
        reduction: function(){
            if(this.amount != 0){
                this.amount--
            }
        },
        increase: function(){
            this.amount++
        }
    },
}
</script>
<style scoped>
.isHide{
    display: none;
}
.product-dialog{
    background-color: rgba(168, 168, 168, 0.5);
    z-index: 4;
    position: fixed;
    top: 0px;
    width: 100%;
    height: 850px;
}
.product-dialog-content{
    background: white;
    height: 550px;
    width: 60%;
    margin: 20px auto;
    border-radius: 8px;
    display: flex;
}
.product-dialog-close{
    width: 40%;
}
.product-name{
    font-weight: 600;
    font-size: 24px;
    margin-top: 40px;
    padding-left: 20px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.product-price{
    font-weight: 600;
    font-size: 20px;
    margin-top: 20px;
    padding-left: 20px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.product-dialog-right{
    width: 60%;
}
.product-image-content img{
    height: 350px;
    width: 300px;
    margin: 10px;
}
.product-dialog-close{
    margin-top: 10px;
    width: 98%;
    display: flex;
    justify-content: flex-end;
}
.product-dialog-close:hover img{
    cursor: pointer;
}
.btn-add{
    padding: 10px 15px;
    /* border: 1px solid black; */
    border-radius: 10px;
    width: 150px;
    cursor: pointer;
    margin: 30px 20px;
    font-size: 18px;
    color: white;
    background-color: rgba(255, 0, 0, 0.7);
}
.product-amount{
    margin: 10px 20px;
}
.product-amount input{
    width: 15%;
    text-align: center;
    padding: 3px 0px;
}
.product-amount button{
    outline: none;
    border: none;
    width: 30px;
    height: 25px;
    cursor: pointer;
}
.product-note{
    margin: 20px;
}
</style>