<template>
    <div class="left">
        <div>
            <title-left :title="titles[0]"/>
            <div class="left-border-bottom"></div>
        </div>
        <div>
            <div>
                <title-left :title="titles[1]"/>
                <div class="left-border-bottom"></div>
                    <checkbox-basic> Ice Cream (8)</checkbox-basic>
                    <checkbox-basic> Cakes (8)</checkbox-basic>
                    <checkbox-basic> Drinks (8)</checkbox-basic>
                    <checkbox-basic> Chicken (8)</checkbox-basic>
                    <checkbox-basic> Fruit (8)</checkbox-basic>
            </div>
            <div>
                <title-left :title="titles[2]"/>
                <div class="left-border-bottom"></div>
                <checkbox-basic> S (6)</checkbox-basic>
                <checkbox-basic> M (6)</checkbox-basic>
                <checkbox-basic> L (6)</checkbox-basic>
            </div>
            <div>
                <title-left :title="titles[3]"/>
                <div class="left-border-bottom"></div>
                <div class="input-color">
                <checkbox-basic> White (4)</checkbox-basic>
                <checkbox-basic> White (4)</checkbox-basic>
                <checkbox-basic> White (4)</checkbox-basic>
            </div>
            <div>
            <title-left :title="titles[4]"/>
                <div class="left-border-bottom"></div>
            </div>
            <div>
                <title-left :title="titles[5]"/>
                <div class="left-border-bottom"></div>
            </div>
            <div>
                <title-left :title="titles[6]"/>
                <div class="left-border-bottom"></div>
            </div>
        </div>



        </div>
        <div class="left-banner">
            <img src="../../assets/img/banner/food/Creative-banner-for-social-network.jpg" alt="" srcset="">
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
                "Filter By Price",
                "Products",
                "Size",
                "Color",
                "Components",
                "Styles",
                "Properties"
            ]
            
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
    margin-top: 200px;
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