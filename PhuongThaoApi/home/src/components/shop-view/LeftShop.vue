<template>
    <div class="left">
        <div>
            <!-- <title-left :title="titles[0]"/> -->
            <!-- <div class="left-border-bottom"></div> -->
        </div>
        <div>
            <div>
                <title-left :title="titles[0]"/>
                <div class="left-border-bottom"></div>
                    <checkbox-basic @click="Icecream"> Kem (8)</checkbox-basic>
                    <checkbox-basic @click="Cake"> Bánh ngọt (8)</checkbox-basic>
                    <checkbox-basic @click="Drink"> Nước uống (8)</checkbox-basic>
                    <checkbox-basic @click="Snack"> Đồ ăn vặt (8)</checkbox-basic>
                    <checkbox-basic @click="Fruit"> Trái cây (8)</checkbox-basic>
            </div>
            <div>
                <title-left :title="titles[2]"/>
                <div class="left-border-bottom"></div>
                <checkbox-basic> Trên 100.000</checkbox-basic>
                <checkbox-basic> Trên 200.000</checkbox-basic>
                <checkbox-basic> Trên 500.000</checkbox-basic>
            </div>
        </div>
        <div class="left-banner">
            <marquee width="100%" direction="up" height="500px">
            <img src="../../assets/img/banner/food/Creative-banner-for-social-network.jpg" alt="" srcset="">
            <img src="../../assets/img/banner/food/banner-2.jpg" alt="" srcset="">
            </marquee>
        </div>

    </div>
</template>
<script>
import CheckboxBasic from '../base/CheckboxBasic.vue'
import TitleLeft from './title-left/TitleLeft.vue'
export default {
  components: { 
      TitleLeft,
      CheckboxBasic
      },
    data() {
        return {
            titles:[
                // "Filter By Price",
                "Products",
                "Size",
                "Giá",
                "Components",
                "Styles",
                "Properties"
            ]
            
        }
    },
    methods: {
        Icecream: function(){
            this.$emit('')
        }
    },
}
</script>
<style scoped>
.left{
    width: 300px;
    height: 1000px;
    background: #f5f5f5;
}
.left-banner{
    margin-top: 100px;
}
.left-banner img{
    width: 300px;
    height: 500px;
}
.left-border-bottom{
    border-bottom: 2.5px solid #c7b270;
    width: 100px;
    margin-left: 20px;
}
.checkbox-content{
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    margin: 20px 20px;
}
input[type="checkbox"]{
    height: 15px;
    width: 15px;
}

.input-color-element{
    height: 15px;
    width: 15px;
}
.input-color-white{
    background: white;
}
</style>