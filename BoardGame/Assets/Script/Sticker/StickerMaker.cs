using UnityEngine;
using UnityEngine.UI;

public class StickerMaker : MonoBehaviour
{
    [SerializeField]
    private Sticker stickerPrefabs;

    [SerializeField]
    private Transform stickerGroup;

    public void MakeSticker(Image image)
    {
        Sticker sticker = Instantiate<Sticker>(stickerPrefabs);

        sticker.transform.position = Vector3.zero;
        sticker.transform.rotation = Quaternion.identity;
        sticker.transform.localScale = Vector3.one;

        sticker.transform.parent = stickerGroup;

        sticker.SetSprite(image.sprite);
    }
}
