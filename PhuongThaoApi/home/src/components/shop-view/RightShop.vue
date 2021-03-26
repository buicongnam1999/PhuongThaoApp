<template>
    <div class="right">
        <div class="grid-top">
            <div class="grid-top-left">
                <div style="margin:28px 10px 0 20px">
                    <img src="../../assets/icon/toggle.png" alt="" srcset="" width="30px" height="30px">
                </div>
            </div>
            <div class="grid-top-sort">
                Sort By:
                <div class="input-sort">
                    <div class="input-sort-text">
                        Relavance
                    </div>
                    <div class="input-sort-button">
                        <i class="fa fa-angle-down" aria-hidden="true"></i>
                    </div>
                </div>
            </div>
        </div>
        <div class="grid-content">
            <div class="grid-content-product">
                <grid-element v-for="food in foods.slice(0,11)" :key="food.food_id">
                    <right-img :img="food.food_img" />
                    <div class="grid-element-text">{{food.food_name}}</div>
                    <div class="grid-element-price"><b>{{food.food_money}} VNĐ</b></div>
                    <div style="margin-top: 10px" class="button">
                        <button @click="Addtocart(food.food_id)">Thêm vào giỏ hàng</button>
                    </div>
                </grid-element>
            </div>
        </div>
        <pop-up-basic :isHide="isHide">
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
import axios from "axios";
import GridElement from './GridElement.vue'
import PopUpBasic from '../base/PopUpBasic.vue';
import RightImg from './RightImg.vue';
import swal from 'sweetalert';
export default {
    components:{
        GridElement,
        PopUpBasic,
        RightImg
    },
    data() {
        return {
            foods:[],
            id: 0,
            isHide: true,
            console:{
                "error": null,
                "sucess": true,
                "data": {
                    "devMessage": null,
                    "userMessage": ""
                }
            }
        }
    },
    methods: {
        Addtocart(id){
            this.isHide = !this.isHide
            this.id = id
        },
        async Ok(){
            await axios.post("https://localhost:44344/api/cart/1&&"+this.id)
            .then(res => this.console = res.data)
            if(this.console.sucess){
                swal("Thêm thành công", "Cảm ơn bạn đã thêm vào giỏ hàng!","success");
            }
            this.id = 0
            this.isHide = !this.isHide
        },
        Cancel: function(){
            this.isHide = !this.isHide
        }
    },
    async created() {
        await axios.get("https://localhost:44344/api/food")
        .then(res => this.foods = res.data)
        console.log(this.foods)
    },
}
</script>
<style scoped>
.right{
    width: 980px;
    height: 1910px;
}
.grid-top{
    border: 1px solid #e5e5e5;
    height: 80px;
    background-color: white;
    display: flex;
    margin-left: 29px;
}
.grid-top-left{
    display: flex;
}
.common i{
    color: black;
    margin: 30px 0px;
    font: 50px;
}
.grid-top-sort{
    width: 355px;
    line-height: 80px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    display: flex;
    justify-content: flex-end;
    width: 95%;
}
.input-sort{
    border: 1px solid #e5e5e5;
    border-radius: 4px;
    height: 35px;
    width: 290px;
    display: flex;
    justify-content: flex-end;
    margin:22.5px 10px;

}
.input-sort-text,.input-sort-button{
    line-height: 36px;
}
.input-sort-text{
    margin-left: 10px;
    width: 90%;
}
.input-sort-button{
    margin-right: 10px;
    justify-content: flex-end;
}
.grid-content{
    margin-top: 25px;
}
.button button{
    border: none;
    outline: none;
    background: red;
    padding: 5px 10px;
    font-size: 18px;
    cursor: pointer;
}
.grid-content-product{
}
.grid-element-text{
    margin-top: 20px;
    cursor: pointer;
}
.grid-element-text:hover{
    color: red;
    opacity: 0.9;
}
.grid-element-price{
    margin-top: 10px;
    font-size: 15px;
}
</style>