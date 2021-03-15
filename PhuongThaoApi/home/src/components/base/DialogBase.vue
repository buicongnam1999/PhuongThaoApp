<template>
    <div :class="{isHide: isHide}">
        <div class="dialog">
            <div class="dialog-content">
                <div class="dialog-content-title">
                    <slot name="title"></slot>
                </div>
                <div class="dialog-content-message">
                    <slot name="message"></slot>
                </div>
                <div class="button">
                    <slot name="button"></slot>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    props:{
        isHide: Boolean
    },
    data() {
        return {
            
        }
    },
}
</script>

<style scoped>
.dialog{
    position: fixed;
    top: 0;
    background: rgba(0,0,0,0.5);
    width: 100%;
    z-index: 1;
    height: 1150px;
}
.dialog-content{
    height: 150px;
    width: 300px;
    border-radius: 5px;
    background: white;
    position: absolute;
    top: 200px;
    left: calc(50% - 150px);
}
.dialog-content-title{
    height: 40px;
    background: yellow;
    opacity: 0.9;
    border-radius: 5px;
    line-height: 40px;
    padding-left: 20px;
}
.dialog-content-message{
    height: 50px;
    padding: 15px 20px;
}
.button{
    width: 50%;
    float: right;
}
.isHide{
    display: none;
}
</style>

