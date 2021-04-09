<template>
    <div :class="{isHide: isHide}">
        <div class="popup">
            <div class="popup-content">
                <div class="popup-content-title">
                    <slot name="title"></slot>
                </div>
                <div class="popup-content-message">
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
    methods: {
        // Ok(){
        //     this.$emit('succes')
        // },
        // Cancel(){
        //     this.$emit('close')
        // },
    },
}
</script>

<style scoped>
.button{
    width: 100%;
    display: flex;
    justify-content: flex-end;
}
.popup{
    position: fixed;
    top: 0;
    background: rgba(0,0,0,0.5);
    width: 100%;
    z-index: 1;
    height: 1150px;
    left: 0;
}
.popup-content{
    height: 150px;
    width: 300px;
    border-radius: 5px;
    background: white;
    position: absolute;
    top: 200px;
    left: calc(50% - 150px);
}
.popup-content-title{
    height: 40px;
    background: #019160;
    border-top-left-radius: 5px;
    border-top-right-radius: 5px;
    line-height: 40px;
    color: white;
    padding-left: 20px;
}
.popup-content-message{
    height: 35px;
    padding: 15px 20px;
}
.btn-cancel,.btn-sucess{
    padding: 10px;
    border-radius: 2px;
    margin-right: 5px;
    cursor: pointer;
    color: white;
}
.btn-sucess{
    background: rgba(1, 145, 96, 0.8);
}
.btn-cancel{
    background: rgba(251, 51, 58, 0.8);
}
.isHide{
    display: none;
}

</style>

