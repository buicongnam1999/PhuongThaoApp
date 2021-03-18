<template>
    <div :class="{isHide: isHide}">
        <div class="product-dialog">
            <div class="product-dialog-content">
                <div class="product-dialog-image">
                    <div class="product-image-content">
                        <img :src="require(`../../assets/img/products/food/${image}`)" alt="" srcset="">
                    </div>
                </div>
                <div class="product-dialog-right">
                    <div class="product-dialog-close">
                        <img src="../../assets/icon/cancel.svg" alt="" srcset="" @click="closeDialog">
                    </div>
                    <div class="product-name">
                        {{name}}
                    </div>
                    <div class="product-price">
                        {{price}}
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            img: '1.jpg'
        }
    },
    props:{
        isHide: Boolean,
        image: String,
        name: String,
        price: String
    },
    created: function(){
        this.img = this.image
    },
    methods: {
        closeDialog: function(){
            this.$emit('CloseDialog')
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
</style>